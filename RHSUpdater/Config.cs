using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace RHSUpdater
{
    class Config
    {
        private const string RHSAPI = "http://www.rhsmods.org/api/mod";

        private string rhsObjectString;
        
        // INDEX  NAME
        // -----------
        //   0    AFRF
        //   1    USAF
        //   2    GREF
        private List<RHSObject> o;

        private string pathArma;
        private string versionAFRF;
        private string versionUSAF;
        private string versionGREF;

        private bool needAFRF;
        private bool needUSAF;
        private bool needGREF;

        private string oldVersionAFRF;
        private string oldVersionUSAF;
        private string oldVersionGREF;

        public string RHSObjectString
        {
            get
            {
                return rhsObjectString;
            }

            set
            {
                rhsObjectString = value;
            }
        }

        public List<RHSObject> O
        {
            get
            {
                return o;
            }

            set
            {
                o = value;
            }
        }

        public string PathArma
        {
            get
            {
                return pathArma;
            }

            set
            {
                pathArma = value;
            }
        }

        public string VersionAFRF
        {
            get
            {
                return versionAFRF;
            }

            set
            {
                versionAFRF = value;
            }
        }

        public string VersionUSAF
        {
            get
            {
                return versionUSAF;
            }

            set
            {
                versionUSAF = value;
            }
        }

        public string VersionGREF
        {
            get
            {
                return versionGREF;
            }

            set
            {
                versionGREF = value;
            }
        }

        public bool NeedAFRF
        {
            get
            {
                return needAFRF;
            }

            set
            {
                needAFRF = value;
            }
        }

        public bool NeedUSAF
        {
            get
            {
                return needUSAF;
            }

            set
            {
                needUSAF = value;
            }
        }

        public bool NeedGREF
        {
            get
            {
                return needGREF;
            }

            set
            {
                needGREF = value;
            }
        }

        public string OldVersionAFRF
        {
            get
            {
                return oldVersionAFRF;
            }

            set
            {
                oldVersionAFRF = value;
            }
        }

        public string OldVersionUSAF
        {
            get
            {
                return oldVersionUSAF;
            }

            set
            {
                oldVersionUSAF = value;
            }
        }

        public string OldVersionGREF
        {
            get
            {
                return oldVersionGREF;
            }

            set
            {
                oldVersionGREF = value;
            }
        }

        public Config()
        {
            Globals.form.writeLog("INFO", "Initialisation des configurations");
            rhsObjectString = new WebClient().DownloadString(RHSAPI);
            O = JsonConvert.DeserializeObject<List<RHSObject>>(rhsObjectString);
            Globals.form.writeLog("LDG", "Récupération de l'API RHS...");

            loadValues();
            System.Console.WriteLine(Properties.Settings.Default.versionAFRF + " " + Properties.Settings.Default.versionUSAF + " " + Properties.Settings.Default.versionGREF);
        }

        private void loadValues()
        {
            if (O != null)
            {
                Globals.form.writeLog("LDG", "Analyse des versions...");
                Globals.form.writeLog("LDG", "Détection du répertoire d'Arma 3...");
                if (!String.IsNullOrEmpty(Properties.Settings.Default.pathArma))
                    PathArma = Properties.Settings.Default.pathArma;
                else
                {
                    Globals.form.openFile.Title = "Localisation de l'exécutable arma3.exe";
                    Globals.form.openFile.FileName = "arma3.exe";
                    if (Globals.form.openFile.ShowDialog() == DialogResult.OK)
                    {
                        pathArma = Path.GetDirectoryName(Globals.form.openFile.FileName);
                        Properties.Settings.Default.pathArma = pathArma;
                    }
                    else if (Globals.form.openFile.ShowDialog() == DialogResult.Cancel)
                        return;
                }
                Globals.form.writeLog("INFO", "Répertoire trouvé !");
                Globals.form.writeLog("INFO", "Analyse des versions...");


                CheckVersions();
            }
        }

        private void CheckVersions()
        {
            // On regarde si les MODS existent déja

            if (!Directory.Exists(Path.Combine(pathArma, "@RHSAFRF")))
            {
                //Telecharger AFRF
                needAFRF = true;
                Globals.form.writeLog("ERR", "AFRF n'a pas été trouvé !");
            }
            else
            {
                //Besoin de mise a jour ?
                if(ReadChangelogVersion("AFRF") != O[0].currentVersion)
                {
                    needAFRF = true;
                    Globals.form.writeLog("ERR", "AFRF n'est pas à jour !");
                }
                else
                {
                    needAFRF = false;
                    Globals.form.writeLog("INFO", "AFRF est à jour !");
                }
            }

            if (!Directory.Exists(Path.Combine(pathArma, "@RHSUSAF")))
            {
                //Telecharger USAF
                needUSAF = true;
                Globals.form.writeLog("ERR", "USAF n'a pas été trouvé !");
            }
            else
            {
                //Besoin de mise a jour ?
                if (ReadChangelogVersion("USAF") != O[1].currentVersion)
                {
                    needUSAF = true;
                    Globals.form.writeLog("ERR", "USAF n'est pas à jour !");
                }
                else
                {
                    needUSAF = false;
                    Globals.form.writeLog("INFO", "USAF est à jour !");
                }
            }

            if (!Directory.Exists(Path.Combine(pathArma, "@RHSGREF")))
            {
                //Telecharger GREF
                needGREF = true;
                Globals.form.writeLog("ERR", "GREF n'a pas été trouvé !");
            }
            else
            {
                //Besoin de mise a jour ?
                if (ReadChangelogVersion("GREF") != O[2].currentVersion)
                {
                    needGREF = true;
                    Globals.form.writeLog("ERR", "GREF n'est pas à jour !");
                }
                else
                {
                    needGREF = false;
                    Globals.form.writeLog("INFO", "GREF est à jour !");
                }
            }
        }

        private string ReadChangelogVersion(string v)
        {
            string changelogPath = Path.Combine(pathArma,"@RHS" + v,"CHANGELOG.txt");
            const int LINE_VERSION = 11;

            if(File.Exists(changelogPath))
            {
                using (var sr = new StreamReader(changelogPath))
                {
                    for (int i = 1; i < LINE_VERSION; i++)
                        sr.ReadLine();
                    return sr.ReadLine().Substring(2);
                }
            }
            return "";
           
        }

        public void Download(string v)
        {
            string locationBAT = Path.Combine(pathArma, "@RHS" + v, "update_rhs" + v.ToLower() + ".bat");
            if (!Directory.Exists(Path.Combine(pathArma, "@RHS" + v)))
                Directory.CreateDirectory(Path.Combine(pathArma, "@RHS" + v));

            // Creation du dossier

            // Copie des fichiers

            File.Copy(@"Resources\Updaters\update_rhs" + v.ToLower() + ".bat", Path.Combine(pathArma, "@RHS" + v, "update_rhs" + v.ToLower() + ".bat"), true);
            File.Copy(@"Resources\Updaters\libeay32.dll", Path.Combine(pathArma, "@RHS" + v, "libeay32.dll"), true);
            File.Copy(@"Resources\Updaters\libiconv2.dll", Path.Combine(pathArma, "@RHS" + v, "libiconv2.dll"), true);
            File.Copy(@"Resources\Updaters\libintl3.dll", Path.Combine(pathArma, "@RHS" + v, "libintl3.dll"), true);
            File.Copy(@"Resources\Updaters\libssl32.dll", Path.Combine(pathArma, "@RHS" + v, "libssl32.dll"), true);
            File.Copy(@"Resources\Updaters\wget.exe", Path.Combine(pathArma, "@RHS" + v, "wget.exe"), true);
            // Telechargement
            Process proc = null;
            try
            {
                Globals.form.writeLog("LDG", "Téléchargement de RHS : " + v + "...");
                proc = new Process();
                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(locationBAT);
                proc.StartInfo.FileName = locationBAT;
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Globals.form.writeLog("ERR", "Erreur pouur le téléchargement RHS : " + v + " => " + ex);
            }

            Globals.form.writeLog("INFO", "Téléchargement de RHS : " + v + " terminé !");
        }
    }
}

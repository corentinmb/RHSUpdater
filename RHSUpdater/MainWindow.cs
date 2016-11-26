using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHSUpdater
{

  
    public partial class MainWindow : Form
    {
        private Config c;

        public MainWindow()
        {
            InitializeComponent();
        }

    
        public void writeLog(string t, string s)
        {
            if (logBox.InvokeRequired)
                logBox.Invoke((Action)(() => writeLog(t, s)));
            else
            {
                switch (t)
                {
                    case "ERR":
                        logBox.SelectionStart = logBox.TextLength;
                        logBox.SelectionLength = 0;

                        logBox.SelectionColor = Color.Red;
                        logBox.SelectionFont = new Font(logBox.Font, FontStyle.Bold);
                        logBox.AppendText("[ATTENTION]");
                        logBox.SelectionColor = logBox.ForeColor;
                        logBox.SelectionFont = new Font(logBox.Font, FontStyle.Regular);

                        logBox.AppendText(" : " + s);
                        break;
                    case "INFO":
                        logBox.SelectionStart = logBox.TextLength;
                        logBox.SelectionLength = 0;

                        logBox.SelectionColor = Color.Green;
                        logBox.SelectionFont = new Font(logBox.Font, FontStyle.Bold);
                        logBox.AppendText("[INFO]");
                        logBox.SelectionColor = logBox.ForeColor;
                        logBox.SelectionFont = new Font(logBox.Font, FontStyle.Regular);

                        logBox.AppendText(" : " + s);
                        break;
                    case "LDG":
                        logBox.SelectionStart = logBox.TextLength;
                        logBox.SelectionLength = 0;

                        logBox.SelectionColor = Color.DarkOrange;
                        logBox.SelectionFont = new Font(logBox.Font, FontStyle.Bold);
                        logBox.AppendText("[CHARGEMENT]");
                        logBox.SelectionColor = logBox.ForeColor;
                        logBox.SelectionFont = new Font(logBox.Font, FontStyle.Regular);

                        logBox.AppendText(" : " + s);
                        break;
                }
                logBox.AppendText(Environment.NewLine);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Process();
        }

        public void Process()
        {
            Globals.form = this;
            c = new Config();

            AFRFPB.Load(c.O[0].logo);
            USAFPB.Load(c.O[1].logo);
            GREFPB.Load(c.O[2].logo);

            if (c.NeedAFRF)
                stateAFRF.Image = Properties.Resources.error;
            else
                stateAFRF.Image = Properties.Resources.success;

            if (c.NeedUSAF)
                stateUSAF.Image = Properties.Resources.error;
            else
                stateUSAF.Image = Properties.Resources.success;

            if (c.NeedGREF)
                stateGREF.Image = Properties.Resources.error;
            else
                stateGREF.Image = Properties.Resources.success;

            if (c.NeedAFRF || c.NeedUSAF || c.NeedGREF)
                MAJButton.Enabled = true;
        }

        private void MAJButton_Click(object sender, EventArgs e)
        {
            // Téléchargement des mods non-mis a jour
            if (c.NeedAFRF)
                c.Download("AFRF");
            if (c.NeedUSAF)
                c.Download("USAF");
            if (c.NeedGREF)
                c.Download("GREF");

            Process();
        }

        private void FolderAFRFButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(c.PathArma, "@RHSAFRF")))
                System.Diagnostics.Process.Start(Path.Combine(c.PathArma, "@RHSAFRF"));
            else
                MessageBox.Show("Le dossier est introuvable, merci d'installer le mod");
        }

        private void FolderUSAFButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(c.PathArma, "@RHSUSAF")))
                System.Diagnostics.Process.Start(Path.Combine(c.PathArma, "@RHSUSAF"));
            else
                MessageBox.Show("Le dossier est introuvable, merci d'installer le mod");
        }

        private void FolderGREFButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(c.PathArma, "@RHSGREF")))
                System.Diagnostics.Process.Start(Path.Combine(c.PathArma, "@RHSGREF"));
            else
                MessageBox.Show("Le dossier est introuvable, merci d'installer le mod");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitter.com/corentinmb");
        }
    }



    class Globals
    {
        public static MainWindow form;
    }


}

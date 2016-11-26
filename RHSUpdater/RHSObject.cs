using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSUpdater
{
    public class Release
    {
        public string id { get; set; }
        public string version { get; set; }
        public string date { get; set; }
        public string key { get; set; }
    }

    public class RHSObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string currentVersion { get; set; }
        public string logo { get; set; }
        public string readme { get; set; }
        public string changelog { get; set; }
        public List<Release> releases { get; set; }
    }

}

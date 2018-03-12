using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUtauVS
{
    public class ustFile
    {
        private double version;
        private double tempo;
        private int tracks = 1;
        private string pjName;
        private string voicePath;
        private string outFile;
        private string cache;
        private string tool1;
        private string tool2;
        private bool mode2;
        private bool autoren;
        private bool mapFirst;
        private string flags;
        private utaNote[] notes;

        public double Version { get => version; set => version = value; }
        public double Tempo { get => tempo; set => tempo = value; }
        public string PjName { get => pjName; set => pjName = value; }
        public string VoicePath { get => voicePath; set => voicePath = value; }
        public string OutFile { get => outFile; set => outFile = value; }
        public string Cache { get => cache; set => cache = value; }
        public string Tool1 { get => tool1; set => tool1 = value; }
        public string Tool2 { get => tool2; set => tool2 = value; }
        public bool Mode2 { get => mode2; set => mode2 = value; }
        public bool Autoren { get => autoren; set => autoren = value; }
        public bool MapFirst { get => mapFirst; set => mapFirst = value; }
        public string Flags { get => flags; set => flags = value; }

        public utaNote[] Notes { get => notes; set => notes = value; }
    }

}

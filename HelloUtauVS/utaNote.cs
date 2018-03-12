using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUtauVS
{
    public class utaNote
    {
        private int number;
        private int length;
        private int notenum;
        private int tempo;

        public int Notenum { get => notenum; set => notenum = value; }
        public int Length { get => length; set => length = value; }
        public int Number { get => number; set => number = value; }
        public int Tempo { get => tempo; set => tempo = value; }

    }
}

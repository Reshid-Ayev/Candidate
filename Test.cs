using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    class Test
    {
        public Test()
        {

        }
        public Test(int iD, string title, string vA, string vB, string vC, string vD, string vE, string realTrueV)
        {
            ID = iD;
            this.title = title;
            this.vA = vA;
            this.vB = vB;
            this.vC = vC;
            this.vD = vD;
            this.vE = vE;
            this.realTrueV = realTrueV;
        }
        public int ID { get; set; }
        public string title { get; set; }
        public string  vA { get; set; }
        public string vB { get; set; }
        public string vC { get; set; }
        public string vD { get; set; }
        public string vE { get; set; }
        public string realTrueV { get; set; }
        public string trueV { get; set; } = "F";   
    }
}

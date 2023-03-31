using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bojovka
{
    internal class NPC : Herni_postava
    {
        public string prace;
        public int sila;
        public NPC(string jmeno,string prace, int sila) : base (jmeno)
        {
            Jmeno = jmeno;
            this.prace = prace;
            this.sila = sila;
        }
        public NPC(string jmeno, string prace) : base(jmeno)
        {
            Jmeno = jmeno;
            this.prace = prace;
        }
        public override sealed void ZmenaPozice(MouseEventArgs e)
        {
            PoziceX = 100;
            PoziceY = 100;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Práce: " + this.prace + "\n" + "Síla: " + this.sila + "\n" + "\nPozice X: " + PoziceX + "\n" + "PoziceY: " + PoziceY; 
        }
    }
}

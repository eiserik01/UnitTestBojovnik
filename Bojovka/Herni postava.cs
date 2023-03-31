using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bojovka
{
    internal class Herni_postava
    {
        protected string jmeno;
        public string Jmeno
        {
            get
            {
                if(jmeno.Length <= 10)
                {
                    Jmeno = jmeno;                
                }
                MessageBox.Show("404 ERROR! - příliš dlouhé jméno.");
                return Jmeno;
            }
            set { jmeno = value; }
        }

        protected int level = 1;

        protected int PoziceX { get; set; }
        protected int PoziceY { get; set; }

        public Herni_postava(string jmeno)
        {
            Jmeno = jmeno;
        }
        
        public virtual void ZmenaPozice(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PoziceX = e.X;
                PoziceY = e.Y;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nLevel: {level} \nPozice X: {PoziceX}\nPozice Y: {PoziceY}";
        }


    }
}

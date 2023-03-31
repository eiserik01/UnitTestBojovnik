using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bojovka
{
    internal class Hrac : Herni_postava
    {
        public string Specializace
        {
            get
            {           
                return Specializace;
            }
            set 
            {
                string[] ArrayStrings = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
                int i = 0;
                while(i < ArrayStrings.Length)
                {
                    if (value == ArrayStrings[i])
                    {
                        value = ArrayStrings[i];
                    }
                    else i++;
                }
            }
        }
        private enum oblicej
        {
            velkyNos,
            ušoplesk,
            makeUp
        }
        private enum vlasy
        {
            drdol,
            culik,
            pleska
        }
        private enum barvaVlasu
        {
            kastanova,
            blond,
            cervena
        }
        public int XP = 0;
        public Hrac(string jmeno,string specializace, oblicej oblicej, vlasy vlasy, barvaVlasu barvaVlasu) : base(jmeno)
        {
            Jmeno = jmeno;
            Specializace = specializace;
            oblicej = oblicej;
            vlasy = vlasy;
            barvaVlasu = barvaVlasu;
        }
        public void PridejXP(int XP)
        {
            this.XP += XP;
            int pomocna;
            while (this.XP >= 100)          //uzivatel zada 180
            {
                pomocna = this.XP % 100;     //180%100 = 80; ulozi do pomocne
                level++;                    //level nahoru
                this.XP = pomocna;   
            }          
        }
        public override string ToString()
        {
            return "Specializace je: " +Specializace + "\n" + "Obličej: "+ enum Hrac.oblicej + "\n" + "Vlasy: "+this.vlasy + "\n" + "Barva vlasů: "+this.barvaVlasu + "XP: "+this.XP;
        }
    }
}

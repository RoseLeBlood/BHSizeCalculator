using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHTool.Daten
{
    public class BH
    {
        public enum Buchstabe
        {
            AA = 0,
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            Max
        }
        public Buchstabe Letter { get; set; }
        public int Unterbrust { get; set; }

        public BH(string unterbrust, string brust)
            : this(double.Parse(unterbrust), double.Parse(brust)) { }
        
        public BH(double dunterbrust, double dbrust)
        {
            Unterbrust = CalcUnterbrust(dunterbrust);
            Letter = CalcBuchstabe(Unterbrust, dbrust);
        }
        public override string ToString()
        {
            return string.Format("EU: {0} (FR/BE/SP: {1})", ToString(false), ToString(true));
        }
        public string ToString(bool frankreich)
        {
            return string.Format("{0} {1}", (frankreich ? Unterbrust + 15 : Unterbrust), Letter);
        }
        private int CalcUnterbrust(double cm)
        {
            int ergebnis = 0;

            double a = (cm + 2.5) / 5;
            ergebnis = ((int)(a)) * 5;
            return ergebnis;
        }
        private Buchstabe CalcBuchstabe(int unterbrust, double brust)
        {
            int ergebniss = 0;

            ergebniss = ((int)brust - unterbrust - 11) / 2;
            if (ergebniss >= (int)Buchstabe.Max || ergebniss < 0)
                throw new Exception("No Size");

            return (Buchstabe)ergebniss;
        }
       
    }
}

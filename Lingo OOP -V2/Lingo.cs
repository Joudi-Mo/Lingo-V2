using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Data;


namespace Lingo_OOP__V2
{
    class Lingo
    {
        //Begin Class Lingo


        //Attributen - variables
        private int intRandomNr;
        private string strRandomWoord;
        Random random = new Random();

        //Constructor 1
        public Lingo()
        {
            
        }

        //Methodes - functions
        public string randomWoord(List<string> listNamen)
        {
            strRandomWoord = "";
            intRandomNr = random.Next(1, listNamen.Count);
            strRandomWoord = listNamen[intRandomNr];
            listNamen.RemoveAt(intRandomNr);
            return strRandomWoord.ToUpper();
        }

        public bool vulWoord(string strWoord)
        {
            bool containsInt = strWoord.Any(char.IsDigit);
            if ((strWoord).Length == 5 && !containsInt && !(strWoord == null) && !(strWoord.Any(Char.IsWhiteSpace)))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Het woord is ongeldig" + Environment.NewLine + "Voer een woord met 5 letters in" );
                return false;
            }
            

        }

        public void checkWoord(string strWoord, string strLingo, bool[] arrayLetterLingoGebruikt, bool[] arrayLetterWoordGebruikt, Color[] arrayColor)
        {
            for (int b = 0; b < 5; b++)
            {
                arrayLetterLingoGebruikt[b] = false;
                arrayLetterWoordGebruikt[b] = false;
                arrayColor[b] = Color.LightBlue;
            }

            for (int i = 0; i < strWoord.Length; i++)
            {
                if (strLingo.Substring(i, 1) == strWoord.Substring(i, 1))
                {
                    arrayColor[i] = Color.Red;
                    arrayLetterLingoGebruikt[i] = true;
                    arrayLetterWoordGebruikt[i] = true;
                }
            }

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (strWoord.Substring(j, 1) == strLingo.Substring(i, 1) && arrayLetterLingoGebruikt[i] == false && arrayLetterWoordGebruikt[j] == false)
                    {
                        arrayColor[j] = Color.Yellow;
                        arrayLetterLingoGebruikt[i] = true;
                        arrayLetterWoordGebruikt[j] = true;
                    }
                }
            }

        }

        public void resetBord(Label[] arrayLabels, string strLingo, Color[] arrayColor, bool[] arrayLetterLingoGebruikt, bool[] arrayLetterWoordGebruikt)
        {
            for (int i = 0; i < 25; i++)
            {
                arrayLabels[i].Text = "";
                arrayLabels[i].BackColor = Color.LightBlue;
            }
            for (int t = 0; t < 5; t++)
            {
                arrayColor[t] = Color.LightBlue;
                arrayLetterLingoGebruikt[t] = false;
                arrayLetterWoordGebruikt[t] = false;
                
            }
            for (int i = 0; i < 25; i+=5)
            {
                arrayLabels[i].Text = (strLingo.Substring(0, 1)).ToUpper();
                arrayLabels[i + 1].Text = (strLingo.Substring(1, 1)).ToUpper();

            }
        }

        //End class Lingo
    }
}

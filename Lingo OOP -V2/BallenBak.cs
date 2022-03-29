using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lingo_OOP__V2
{
    class BallenBak
    {
        List<string> listBallen = new List<string> { "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Groen", "Groen" };

        Random r = new Random();
        public void listVullen(List<int> listGetallenEven, List<int> listGetallenOneven, List<int> listGetallenKaartEven, List<int> listGetallenKaartOneven)
        {
            for(int i = 1; i < 71; i++)
            {
                if(i % 2 == 0)
                {
                    listGetallenEven.Add(i);
                }
                else
                {
                    listGetallenOneven.Add(i);
                }
            }
            for(int i = 0; i < 25; i++)
            {
                int intRandomBal = r.Next(listGetallenEven.Count);
                int intEvenBal = listGetallenEven[intRandomBal];
                listGetallenKaartEven.Add(intEvenBal);
                listGetallenEven.Remove(intEvenBal);

                intRandomBal = r.Next(listGetallenOneven.Count);
                intEvenBal = listGetallenOneven[intRandomBal];
                listGetallenKaartOneven.Add(intEvenBal);
                listGetallenOneven.Remove(intEvenBal);
            }
            
        }

        public void balPakken(Label[] arraySpeelBord, List<int> listCijfers, bool boolBeurt, List<string> listBallen)
        {

            int intRandomGetal = r.Next(listBallen.Count);
            string strBal = listBallen[intRandomGetal];
            listBallen.Remove(strBal);

            intRandomGetal = r.Next(listCijfers.Count);
            int intLingoBal = listCijfers[intRandomGetal];
            int intTag;
            for(int i = 0; i < listCijfers.Count; i++)
            {
                intTag = Convert.ToInt32(arraySpeelBord[1].Tag);
                if (intLingoBal == intTag)
                {
                    arraySpeelBord[1].Text = intTag.ToString();
                    if (boolBeurt)
                    {
                        arraySpeelBord[1].BackColor = Color.Turquoise; 
                    }
                    else
                    {
                        arraySpeelBord[1].BackColor = Color.Orange;
                    }                    
                }
            }
            listCijfers.Remove(intLingoBal);

        }
    }
}

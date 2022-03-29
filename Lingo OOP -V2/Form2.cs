using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lingo_OOP__V2
{
    public partial class Form2 : Form
    {
        //Even = Team 1 , Oneven = Team 2
        Label[] arrayKaartEven = new Label[25];
        Label[] arrayKaartOneven = new Label[25];
        //True = Team 1 beurt, False = Team 2 beurt, 
        //bool boolBeurt;
        List<int> listGetallenEven = new List<int> { };
        List<int> listGetallenOneven = new List<int> { };
        List<int> listGetallenKaartEven = new List<int> { };
        List<int> listGetallenKaartOneven = new List<int> { };
        List<int> listGestreeptGetallenTeam1 = new List<int> {2,8,10,13,14,16,17,24 };
        List<int> listGestreeptGetallenTeam2 = new List<int> { 0, 3, 5, 7, 9, 17, 19, 24};
        List<string> listBallen = new List<string> { "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Blauw", "Groen", "Groen" };


        Random r = new Random();

        BallenBak BallenBak = new BallenBak();
        public Form2()
        {
            InitializeComponent();
            BallenBak.listVullen(listGetallenEven, listGetallenOneven, listGetallenKaartEven, listGetallenKaartOneven);
            startScherm(arrayKaartEven, listGetallenKaartEven, 25, 110, Color.Turquoise, true);
            startScherm(arrayKaartOneven, listGetallenKaartOneven, 825, 110, Color.Orange, false);
        }

        public void startScherm(Label[] arraySpeelBord, List<int> listCijfers, int intX, int intY, Color colorKLeur, bool boolBeurt)
        {
            int j = 0;
            int b = 0;
            int c = 0;
            int u = 0;
            for (int i = 0; i < arraySpeelBord.Length; i++)
            {
                arraySpeelBord[i] = new Label();
                arraySpeelBord[i].BackColor = colorKLeur;
                arraySpeelBord[i].Font = new Font("Poppins", 25);
                arraySpeelBord[i].TextAlign = ContentAlignment.MiddleCenter;
                arraySpeelBord[i].Tag = i;
                arraySpeelBord[i].Size = new Size(100, 100);
                int intRandomGetal = r.Next(listCijfers.Count);
                int intLingoBal = listCijfers[intRandomGetal];
                arraySpeelBord[i].Text = intLingoBal.ToString();
                listCijfers.Remove(intLingoBal);     
                

                //Positie van de labeles goed instellen
                switch (i)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        arraySpeelBord[i].Location = new Point(35 + intX + i * 105, 150 + intY);

                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        arraySpeelBord[i].Location = new Point(35 + intX + j * 105, 255 + intY);
                        j++;
                        break;


                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                        arraySpeelBord[i].Location = new Point(35 + intX + b * 105, 360 + intY);
                        b++;
                        break;


                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        arraySpeelBord[i].Location = new Point(35 + intX + c * 105, 465 + intY);
                        c++;
                        break;
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                        arraySpeelBord[i].Location = new Point(35 + intX + u * 105, 570 + intY);
                        u++;
                        break;
                    default:
                        break;
                }

                this.Controls.Add(arraySpeelBord[i]);
            }


            for(int i = 0; i < 8; i++)
            {
                if (boolBeurt)
                {
                    listCijfers.Add(listGestreeptGetallenTeam1[i]);
                    arraySpeelBord[listGestreeptGetallenTeam1[i]].Text = "";
                    arraySpeelBord[listGestreeptGetallenTeam1[i]].BackColor = Color.Gray;
                    listBox1.Items.Add(listCijfers[i]);
                    listBox1.Items.Clear();
                    for (int g = 0; g < listCijfers.Count; g++)
                    {
                        listBox1.Items.Add(listCijfers[g]);
                    }
                }
                else
                {
                    listCijfers.Add(listGestreeptGetallenTeam2[i]);
                    arraySpeelBord[listGestreeptGetallenTeam2[i]].Text = "";
                    arraySpeelBord[listGestreeptGetallenTeam2[i]].BackColor = Color.Gray;
                    listBox2.Items.Clear();
                    for (int r = 0; r < listCijfers.Count; r++)
                    {
                        listBox2.Items.Add(listCijfers[r]);
                    }
                }
                listBox1.Sorted = true;
                listBox2.Sorted = true;
            }
           

        }

        private void btnTrek_Click(object sender, EventArgs e)
        {
            //Balpakken
        }
    }
}

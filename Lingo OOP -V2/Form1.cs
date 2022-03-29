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
    public partial class Form1 : Form
    {

        //variabels
        List<string> listNamen = new List<string>(){ "Jesse", "Thijs" , "Ruben", "Sanne" , "Peter",
            "Niels" , "Robin", "Vince" , "Jurre", "Floor" , "Aiden", "Arjan" , "Andre", "Aster",
            "Ayden", "Arwen", "Amani", "Arjen", "Aaron", "Avery","Brent","Bente","Boris","Bjorn","Bowie",
            "Bodhi","Barry","Bruce","Benja","Cesar","Chadi","Calle","sport","Johan" };
        Label[] arrayLabels = new Label[25];
        string strLingo, strWoord;
        int intRij = 0, tellerTimer = 0; 
        bool[] arrayLetterLingoGebruikt = new bool[5];
        bool[] arrayLetterWoordGebruikt = new bool[5];
        Color[] arrayColor = new Color[5];

        //string randomWoord = "Testt";

        Lingo lingo1 = new Lingo();
        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            //BallenBakcs f2 = new BallenBakcs();
            f2.ShowDialog();
            //this.Close();
            startScherm();
        }

        private void btnChecken_Click(object sender, EventArgs e)
        {
            strWoord = (txtWoord.Text).ToUpper();
            txtWoord.Text = "";
            
            if(lingo1.vulWoord(strWoord))
            {
                txtWoord.Enabled = false;
                intRij += 5;
                lingo1.checkWoord(strWoord, strLingo, arrayLetterLingoGebruikt, arrayLetterWoordGebruikt, arrayColor);
                timer1.Start();
                
            }
        }

        private void txtWoord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnChecken_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(arrayLabels[24].Text != "")
            {
                lblListCount.Text = (listNamen.Count).ToString();
                intRij = 0;
                lblRij.Text = intRij.ToString();
                strLingo = lingo1.randomWoord(listNamen);
                lblLingo.Text = strLingo;
                lingo1.resetBord(arrayLabels, strLingo, arrayColor, arrayLetterLingoGebruikt, arrayLetterWoordGebruikt);
                timer1.Stop();
                txtWoord.Enabled = true;
            }

            /*if (intRij == 30)
            {
                
                lblListCount.Text = (listNamen.Count).ToString();
                intRij = 0;
                lblRij.Text = intRij.ToString();
                strLingo = lingo1.randomWoord(listNamen);
                lblLingo.Text = strLingo;
                lingo1.resetBord(arrayLabels, strLingo, arrayColor, arrayLetterLingoGebruikt, arrayLetterWoordGebruikt);
                timer1.Stop();
            }*/
            else
            {
                lblLingo.Text = strLingo;
                lblListCount.Text = (listNamen.Count).ToString();
                lblRij.Text = intRij.ToString();
                arrayLabels[tellerTimer + intRij - 5].BackColor = arrayColor[tellerTimer];
                arrayLabels[tellerTimer + intRij - 5].Text = strWoord.Substring(tellerTimer, 1);
                tellerTimer++;
                if (tellerTimer == 5)
                {
                    tellerTimer = 0;
                    timer1.Stop();
                    txtWoord.Enabled = true;
                }
            }
            

        }

        public void startScherm()
        {
            strLingo = (lingo1.randomWoord(listNamen));
            //strLingo = "JURRE";
            lblLingo.Text = strLingo;
            lblListCount.Text = (listNamen.Count).ToString();

            int j = 0;
            int b = 0;
            int c = 0;
            int u = 0;
            for (int i = 0; i < 25; i++)
            {
                arrayLabels[i] = new Label();
                arrayLabels[i].BackColor = Color.LightBlue;
                arrayLabels[i].Font = new Font("Poppins", 25);
                arrayLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                arrayLabels[i].Size = new Size(100, 100);

                //Positie van de labeles goed instellen
                switch (i)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        arrayLabels[i].Location = new Point(35 + i * 105, 20);

                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        arrayLabels[i].Location = new Point(35 + j * 105, 125);
                        j++;
                        break;


                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                        arrayLabels[i].Location = new Point(35 + b * 105, 230);
                        b++;
                        break;


                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        arrayLabels[i].Location = new Point(35 + c * 105, 335);
                        c++;
                        break;
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                        arrayLabels[i].Location = new Point(35 + u * 105, 440);
                        u++;
                        break;
                    default:
                        break;
                }

                this.Controls.Add(arrayLabels[i]);
            }
            //De code hieronder zorgt ervoor dat het eerste
            //vak van elke rij de eerste letter van het lingo woord krijgt
            for (int t = 0; t < 25; t += 5)
            {
                arrayLabels[t].Text = (strLingo.Substring(0, 1)).ToUpper();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupideVautour2
{
    public partial class Jeu : Form
    {

        public Jeu()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                PictureBox carte = (PictureBox)DeckJ1.Controls[i];
                carte.Image = SabotJ1.Images[i];
                
            }
            carteJouee_1.Image = SabotJ1.Images[15];
            carteJouee_2.Image = SabotJ1.Images[15];
            carteJouee_3.Image = SabotJ1.Images[15];
            carteJouee_4.Image = SabotJ1.Images[15];
            carteJouee_5.Image = SabotJ1.Images[15];
            carte_SV.Image = SabotJ1.Images[15];
        }

        private void Jeu_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarteJ1_1_Click(object sender, EventArgs e)
        {
            
        }

        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

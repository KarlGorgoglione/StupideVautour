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
        enum Phase { AfficheCarteSV, ChoixCarte, ComparaisonCarte, FinTour };
        Phase tour;
        Random shuffle;
        public static int nbJoueurs;

        public Jeu()
        {
            InitializeComponent();
            DébutJeu();
            

        }

        

        public int indiceHasard()
        {
            shuffle = new Random();
            //int i = (int)(shuffle.Next(DateTime.Now.Millisecond)/5760000);
            int i = shuffle.Next(0, 15);
            return i;
        }

        public void affichCarteSV()
        {
            carte_SV.Image = SabotCaché.Images[indiceHasard()];    
        }

        public void resetCartes()
        {
            carteJouee_1.Image = SabotJ1.Images[15];
            carteJouee_5.Image = SabotJ1.Images[15];
            try
            {             
                carteJouee_2.Image = SabotJ1.Images[15];
            }
            catch (NullReferenceException)
            {

            } try
            {
                carteJouee_3.Image = SabotJ1.Images[15];

            }
            catch (NullReferenceException)
            {

            } try
            {
                carteJouee_4.Image = SabotJ1.Images[15];

            }
            catch (NullReferenceException)
            {

            }
            

            carte_SV.Image = SabotJ1.Images[15];
        }

        private void Jeu_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void CarteJ1_XX_Click(object sender, EventArgs e)
        {
            PictureBox carte = (PictureBox)sender;
            //carte
        }*/

        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Carte_SV_Click(object sender, EventArgs e)
        {

        }

        private void CarteJ1_1_Click(object sender, EventArgs e)
        {
            if (tour == Phase.ChoixCarte)
            {
                PictureBox carte = (PictureBox)sender;
                if (carte.Image != null && carteJouee_1.Image != SabotJ1.Images[15])
                {
                    carteJouee_1.Image = carte.Image;
                    carte.Image = null;
                    tour = Phase.ComparaisonCarte;
                    ComparaisonCarte();
                }
            }
        }

        private void ComparaisonCarte()
        {
            if (tour == Phase.ComparaisonCarte)
            {
                MessageBox.Show("Comparaison des cartes!");
            }
        }


        private void DébutJeu()
        {
            switch (nbJoueurs)
            {
                case(2):
                    carteJouee_4.Hide();
                    carteJouee_4 = null;

                    carteJouee_3.Hide();
                    carteJouee_3 = null;

                    carteJouee_2.Hide();
                    carteJouee_2 = null;
                    
                    break;
                case(3):
                    carteJouee_3.Hide();
                    carteJouee_3 = null;

                    carteJouee_2.Hide();
                    carteJouee_2 = null;
                    
                    break;
                case(4):
                    carteJouee_2.Hide();
                    carteJouee_2 = null;
                    
                    break;
                case(5):
                    break;
            }
            for (int i = 0; i < 15; i++)
            {
                PictureBox carte = (PictureBox)DeckJ1.Controls[i];
                carte.Image = SabotJ1.Images[i];

            }
            resetCartes();
            tour = Phase.AfficheCarteSV;
            MessageBox.Show("Début du tour!!");
            affichCarteSV();
            tour = Phase.ChoixCarte;

            
        }

    }
}

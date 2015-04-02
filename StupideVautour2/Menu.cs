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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_jouer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jeu jeu = new Jeu();
            jeu.Show();
            Jeu.nbJoueurs = nb_joueurs.Text;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void nb_joueurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

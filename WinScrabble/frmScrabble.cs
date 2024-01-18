using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScrabble
{
    public partial class frmScrabble : Form
    {
        // attributs de la classe frmScrabble (variables globales)
        // utiles pour les évolutions EVO01 et EVO02
        int totalPoints = 0;                // nombre de points du joueur
        int nbMots = 0;                     // nombre de mots proposés par le joueur
        string[] lesMots = new string[10];  // mots proposés par le joueur

        public frmScrabble()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string lemot = txtMot.Text;
            int nbpoints = Utilitaire.PointsMot(lemot);
            txtPoints.Text = nbpoints.ToString();
        }

        private void btnAutre_Click(object sender, EventArgs e)
        {
            txtMot.Clear();
            txtPoints.Clear();
            txtMot.Focus();
        }
    }
}

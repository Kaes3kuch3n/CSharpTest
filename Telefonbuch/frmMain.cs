using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonbuch
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        //Speichern
        string textSpeichern(string ausloeser)
        {
            return ausloeser + "\n" + "Vorname: " + txtVorname.Text + "\nName: " + txtName.Text + "\nNummer: " + txtNummer.Text + "\n\n";
        }

        //Speichern-Knopf
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            txtEintraege.Text += textSpeichern(btnSpeichern.Text);
        }

        //Löschen-Knopf
        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            if (cbAlles.Checked)
            {
                DialogResult dr = MessageBox.Show("Wirklich alles löschen?", "Löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    deleteAlles();
                }

                cbAlles.Checked = false;

            }
            else
            {
                deleteNeuerEintrag();
            }
        }

        void deleteNeuerEintrag()
        {
            txtVorname.Text = "";
            txtName.Text = "";
            txtNummer.Text = "";
        }

        void deleteAlles()
        {
            txtVorname.Text = "";
            txtName.Text = "";
            txtNummer.Text = "";
            txtEintraege.Text = "";
        }
    }
}

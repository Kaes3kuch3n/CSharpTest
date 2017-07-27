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
    public delegate void CancelEventHandler();
    public delegate void AcceptEventHandler(string file);

    public partial class formOpen : Form
    {
        public formOpen()
        {
            InitializeComponent();
        }

        public event CancelEventHandler CancelOpenForm;
        public event AcceptEventHandler AcceptOpenForm;

        //Button "Öffnen"
        private void btnOpen_Click(object sender, EventArgs e)
        {
            AcceptOpenForm("");
            Close();
        }

        //Button "Abbrechen"
        private void btnClose_Click(object sender, EventArgs e)
        {
            CancelOpenForm();
            Close();
        }
    }
}

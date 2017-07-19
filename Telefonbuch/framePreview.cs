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
    public partial class framePreview : Form
    {
        public framePreview()
        {
            InitializeComponent();
        }

        //Close
        private void framePreview_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

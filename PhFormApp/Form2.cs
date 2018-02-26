using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhFormApp
{
    public partial class PhProcess : Form
    {
        public PhProcess()
        {
            InitializeComponent();
            ColorLabel.Location = new Point(250, 200);
            
        }

        private Color receievedColor = PhForm.colorToSend;

        private void PhProcess_Load(object sender, EventArgs e)
        {
            ColorLabel.BackColor = receievedColor;
        }
    }
}

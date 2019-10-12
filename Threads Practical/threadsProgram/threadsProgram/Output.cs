/*
        ALWYN BARNARD  28430093
        SCHEDULING REPORT 
        Mr Henry Foulds
        ITRW 316 Operating Systems 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadsProgram
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }
        public void OutResult(string value)
        {
            txtOut.Text += value;
        }

        private void Output_Load(object sender, EventArgs e)
        {

        }
    }
}

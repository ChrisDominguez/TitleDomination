using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleDomination
{

    public partial class Form1 : Form
    {
        Truncate trunc = new Truncate();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void titleInput_TextChanged(object sender, EventArgs e)
        {
            titleOutput.Text = trunc.AtWord(titleInput.Text);

            // :p
            dominatedLabel.Text = (this.trunc.isDominated ? "TITLE DOMINATED!!!" : "");
        }
    }
  
}
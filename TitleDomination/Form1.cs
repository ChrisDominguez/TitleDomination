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
        }
    }

    public class Truncate
    {
        int Google = 60;

        public String AtWord(string input, int length)
        {
            if (input == null || input.Length < length)
                return input;
            int lastSpace = input.LastIndexOf(" ", length);
            return string.Format("{0}...", input.Substring(0, (lastSpace > 0) ? lastSpace : length).Trim());
        }

        public String AtWord(string input)
        {
            return this.AtWord(input, Google);
        }
    }
}
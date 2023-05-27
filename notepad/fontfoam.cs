using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class fontfoam : Form
    {
        public fontfoam()
        {
            InitializeComponent();
        }

        private void fontfoam_Load(object sender, EventArgs e)
        {
            List<string> fonts = new List<string>();
            foreach(FontFamily font in FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            fontcombo.DataSource = fonts.ToList();
          
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblfont_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}

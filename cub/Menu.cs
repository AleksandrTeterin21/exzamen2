using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cub
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                this.BackColor = colorDialog1.Color;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cub f = new Cub();
            f.Show();
                this.Hide();
            f.BackColor = this.BackColor;
        }
    }
}

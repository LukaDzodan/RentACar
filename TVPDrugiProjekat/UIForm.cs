using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPDrugiProjekat
{
    public partial class UIForm : Form
    {
        int sec = 0;
        public UIForm()
        {
            InitializeComponent();
        }

        private void UIForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if(sec == 1)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}

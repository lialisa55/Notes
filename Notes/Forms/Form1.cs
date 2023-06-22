using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notes.Forms;
using Notes.Entities;

namespace Notes
{
    public partial class Form1 : Form
    {
        Notas nota = new Notas();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nota.CreateNote());
            
        }
        public void CriarRTB()
        {
            RichTextBox rtb = new RichTextBox();
            rtb.Location = new System.Drawing.Point(175, 46);
            rtb.Width = 160;
            rtb.Height = 80;
            this.Controls.Add(rtb);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nota form = new nota();
            form.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

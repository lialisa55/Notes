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
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notes
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
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
        private void Principal_Load(object sender, EventArgs e)
            {
            if (!GestaoLogin.IsLogged())
                {
                Login login = new Login();
                login.ShowDialog();
                this.Hide();
                }
            if (Notas.TextDefined())
                {
                Notas.ZeroLine();
                List<string> titulo = new List<string>(ControleBD.GetTitulo(GestaoLogin.GetId()));
                List<string> conteudo = new List<string>(ControleBD.GetConteudo(GestaoLogin.GetId()));
                for (int i = 0; i < Notas.GetAmount(); i++)
                    {
                    this.Controls.Add(Notas.CreateNote(i, titulo[i], conteudo[i]));
                    }
                }
            if (ControleBD.GetQnt(GestaoLogin.GetId()) > 0)
                {
                Notas.ZeroLine();
                List<string> titulo = new List<string>(ControleBD.GetTitulo(GestaoLogin.GetId()));
                List<string> conteudo = new List<string>(ControleBD.GetConteudo(GestaoLogin.GetId()));
                for (int i = 0; i < Notas.GetAmount(); i++)
                    {
                    this.Controls.Add(Notas.CreateNote(i, titulo[i], conteudo[i]));
                    }
                }
            }

        private void tsbBackup_Click(object sender, EventArgs e)
            {
            MessageBox.Show(ControleBD.Backup("C:\\Users\\Monkold\\Documents\\clooone\\Notes\\Backup"));
            }
        }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notes.Entities;

namespace Notes.Forms
{
    public partial class nota : Form
    {
        ControleBD controler = new ControleBD();
        public nota()
        {
            InitializeComponent();
        }
        public nota(string titulo, string conteudo)
            {
            InitializeComponent();
            mtbTitulo.Text = titulo;
            rtbConteudo.Text = conteudo;
            }

        private void btnSalvar_Click(object sender, EventArgs e)
            {
            Principal form = new Principal();
            Notas.SetText(mtbTitulo.Text, rtbConteudo.Text);
            controler.SetNotes(mtbTitulo.Text, rtbConteudo.Text, GestaoLogin.GetId());
            Notas.AddAmount();
            this.Hide();
            }

        private void btnVoltar_Click(object sender, EventArgs e)
            {
            Principal form = new Principal();
            form.Show();
            this.Hide();
            }
        }
}

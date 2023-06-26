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
using System.Threading;

namespace Notes.Forms
    {
    public partial class Login : Form
        {
        public Login()
            {
            InitializeComponent();
            }

        private void label3_Click(object sender, EventArgs e)
            {
            Registrar registrar = new Registrar();
            registrar.ShowDialog();
            this.Hide();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            MessageBox.Show(GestaoLogin.Login(tbUsername.Text, mtbSenha.Text));
            if (GestaoLogin.IsLogged())
                {
                ControleBD.QntNotes(GestaoLogin.GetId());
                this.Hide(); 
                    
                }
            }
        }
    }

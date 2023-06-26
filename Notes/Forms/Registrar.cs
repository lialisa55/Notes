using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Notes.Entities;

namespace Notes.Forms
    {
    public partial class Registrar : Form
        {
        ControleBD controle = new ControleBD();
        public Registrar()
            {
            InitializeComponent();
            }

        private void Registro_Click(object sender, EventArgs e)
            {
            string name = textBox1.Text;
            string user = TbUsername.Text;
            string senha = mtbSenha.Text;
            MessageBox.Show(controle.Registrar(name, user, senha));
            Login login = new Login();
            login.Show();
            this.Hide();
            }

        private void label3_Click(object sender, EventArgs e)
            {
            Login login = new Login();
            login.Show();
            this.Hide();
            }
        }
    }

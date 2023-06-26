using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Notes.Entities
    {

    class Conexao
        {
        public MySqlConnection conexao = new MySqlConnection(@"server = localhost;Port=3306;Database=notas;User=root;Pwd=;");
        public void Conectar()
            {
            try
                {
                conexao.Open();
                Console.WriteLine("Conexão realizada com sucesso");
                }
            catch (MySqlException erro)
                {
                Console.WriteLine(erro.ToString());
                }
            }
        public void Desconectar()
            {
            try
                {
                conexao.Close();
                Console.WriteLine("Conexão encerada");
                }
            catch (MySqlException erro)
                {
                Console.WriteLine(erro.ToString());
                }
            }       


        }
    }


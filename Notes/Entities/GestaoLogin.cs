using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.Entities
    {
    internal class GestaoLogin
        {
        private static bool Logged;
        private static int id;
        public static bool IsLogged()
            {
            Console.WriteLine(Logged);
            return Logged;
            }
        public static void OnLogin()
            {
            Logged = true;
            }
        public static void OffLogin()
            {
            Logged = false;
            }
        public static string Login(string user, string pass)
            {
            Conexao conect = new Conexao();
            string sql = $"select username, senha, id_user from login where username = '{user}' and senha = '{pass}';";
            MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

            try
               {
               conect.Conectar();
               MySqlDataReader readerDate = cmd.ExecuteReader();
               if (!readerDate.HasRows)
                   {
                    OffLogin();
                    return "Erro ao fazer o Login";
                   }
               else
                    {
                    readerDate.Read();
                    string idi = readerDate["id_user"].ToString();
                    readerDate.Close();
                    Console.WriteLine(idi);
                    id = int.Parse(idi);
                    OnLogin();
                    return "Logado com sucesso";
                    }
                    }
            catch (MySqlException e)
                {
                return (e.ToString());
                }
            finally
                {
                conect.Desconectar();
                }

                }
        public static int GetId()
            {
            return id;
            }
            }
    }

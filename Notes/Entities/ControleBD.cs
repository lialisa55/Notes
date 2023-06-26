using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Entities;

namespace Notes.Entities
    {
    internal class ControleBD
        {
        Conexao conect = new Conexao();
        public string Registrar(string nome, string username, string senha)
            {
            try
                {
                string comand = $"INSERT INTO login(nome, username, senha)" +
                $"VALUES('{nome}', '{username}', '{senha}')";
                Console.WriteLine(comand);
                MySqlCommand cmd = new MySqlCommand(comand, conect.conexao);

                conect.Conectar();
                cmd.ExecuteNonQuery();
                conect.Desconectar();

                return ("Cadastro realizado com sucesso");
                }
            catch (MySqlException erro)
                {
                return (erro.ToString());
                }
            }
        public string SetNotes(string titulo, string conteudo, int id)
            {
            try
                {
                string sql = "INSERT INTO nota(titulo, conteudo, username)"+
                    $"VALUES('{titulo}', '{conteudo}', '{id}')";
                MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

                conect.Conectar();
                cmd.ExecuteNonQuery();
                conect.Desconectar();
                return "Salvo com sucesso";
                }
            catch (MySqlException erro)
                {
                return (erro.ToString());
                }
            }
        public static void QntNotes(int id)
            {
            Conexao conect = new Conexao();
            try
                {
                string sql = $"SELECT qnt from login where id_user = {id}";
                MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

                conect.Conectar();
                MySqlDataReader readerDate = cmd.ExecuteReader();
                readerDate.Read();
                string conver = readerDate["qnt"].ToString();
                readerDate.Close();
                int qnt = int.Parse(conver);
                Notas.SetAmount(qnt);
                }
            finally
                {
                conect.Desconectar();
                }
            }
        public static void AddQnt(int id)
            {
            Conexao conect = new Conexao();
            try
                {
                string sql = $"SELECT qnt from login where id_user = {id}";
                MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

                conect.Conectar();
                MySqlDataReader readerDate = cmd.ExecuteReader();
                readerDate.Read();
                string conver = readerDate["qnt"].ToString();
                readerDate.Close();
                int qnt = int.Parse(conver) + 1;
                string sqlFinally = $"update login SET qnt = {qnt} where id_user = {id}";
                MySqlCommand execute = new MySqlCommand(sqlFinally, conect.conexao);
                execute.ExecuteNonQuery();
                }
            finally
                {
                conect.Desconectar();
                }
            }
        public static int GetQnt(int id)
            {
            Conexao conect = new Conexao();
            try
                {
                string sql = $"SELECT qnt from login where id_user = {id}";
                MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

                conect.Conectar();
                MySqlDataReader readerDate = cmd.ExecuteReader();
                readerDate.Read();
                string conver = readerDate["qnt"].ToString();
                readerDate.Close();
                int qnt = int.Parse(conver);
                return qnt;
                }
            finally
                {
                conect.Desconectar();
                }
            }
        public static List<string> GetConteudo(int id)
            {
            Conexao conect = new Conexao();
            try
                {
                string sql = $"SELECT conteudo from nota where username = {id} order by id;";
                MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);
                List<string> list = new List<string>();

                conect.Conectar();
                MySqlDataReader readerDate = cmd.ExecuteReader();
                while (readerDate.Read())
                    {
                    string conver = readerDate["conteudo"].ToString();
                    Console.WriteLine(conver);
                    list.Add(conver);
                    }
                Console.WriteLine(list);
                return list;
            }
            finally
                {
                conect.Desconectar();
                }
            }
        public static List<string> GetTitulo(int id)
            {
            Conexao conect = new Conexao();
            try
                {
                string sql = $"SELECT titulo from nota where username = {id} order by id;";
                MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

                List<string> list = new List<string>();

                conect.Conectar();
                MySqlDataReader readerDate = cmd.ExecuteReader();
                
                while (readerDate.Read())
                    {
                    string conver = readerDate["titulo"].ToString();
                    list.Add(conver);
                }
                return list;
            }
            finally
                {
                conect.Desconectar();
                }
            }
        public static string Backup(string Caminho)
            {
            Conexao conect = new Conexao();
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string CaminhoBackup = Caminho + "\\backupNote_" + dataAtual + ".sql";

            try
                {
                MySqlCommand cmd = new MySqlCommand(CaminhoBackup, conect.conexao);
                MySqlBackup mb = new MySqlBackup(cmd);
                conect.Conectar();
                mb.ExportToFile(CaminhoBackup);
                conect.Desconectar();
                return ("Backup do banco de dados realizado com sucesso!");
                }
            catch (MySqlException e)
                {
                return (e.ToString());
                }
            }
        public string Retore(string Caminho) //Backup a MySQL database
            {
            Conexao conect = new Conexao();
            try
                {
                MySqlCommand cmd = new MySqlCommand(Caminho, conect.conexao);
                MySqlBackup mb = new MySqlBackup(cmd);
                conect.Conectar();
                mb.ImportFromFile(Caminho);
                conect.Desconectar();
                return ("Banco de dados restaurado com sucesso!");
                }
            catch (MySqlException e)
                {
                return (e.ToString());
                }
            }


        }
    }

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Notes.Entities;
using Notes.Forms;

namespace Notes.Entities
{
    class Notas
    {
        private static int Amount;
        private static int Line;
        private static int Location;
        private static int X;
        private static int Y;
        private static string Titulo;
        private static string Conteudo;
        public static bool TextDefined()
            {
            if (Titulo == null && Conteudo == null)
                {
                return false;
                }
            else
                {
                return true;
                }
            }
        public static void SetText(string titulo, string conteudo)
            {
            Titulo = titulo;
            Conteudo = conteudo;
            }
        public static void AddAmount() 
            {
            Amount++;
            ControleBD.AddQnt(GestaoLogin.GetId());
            }
        public static int GetAmount()
            {
            return Amount;
            }
        public static RichTextBox CreateNote(int num, string titulo, string conteudo)
        {
            RichTextBox rtb = new RichTextBox();
            if (num % 2 == 0)
            {
                X = 12;
                Y = 12 + 10 + 80 * Line;
                Line += 1;
            }
            else
            {
                X = 12 + 160 + 5;
            }

            rtb.Location = new System.Drawing.Point(X, Y);
            rtb.Name = "note" + num;
            rtb.Enabled = false;
            rtb.Width = 160;
            rtb.Height = 80;
            rtb.Text = titulo;
            nota form = new nota();
            return rtb;
        }
        public static void ZeroLine()
            {
            Line = 0;
            }
        public static void SetAmount(int amount)
            {
            Amount = amount;
            }
        /*public static RichTextBox CreateNote()
            {
            Amount += 1;
            RichTextBox rtb = new RichTextBox();
            if (Amount % 2 == 0)
                {
                Line += 1;
                X = 12;
                Y = 12 + 10 + 80 * Line;
                }
            else
                {
                X = 12 + 160 + 5;
                }

            rtb.Location = new System.Drawing.Point(X, Y);
            rtb.Name = "note" + Amount;
            rtb.Enabled = false;
            rtb.Width = 160;
            rtb.Height = 80;
            rtb.Text = Titulo;
            return rtb;
            }*/
        
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.Entities
{
    class Notas
    {
        private int amount;
        private int line;
        private int location;
        private int x;
        private int y;
        public RichTextBox CreateNote()
        {
            this.amount += 1;
            RichTextBox rtb = new RichTextBox();
            if (amount % 2 == 0)
            {
                line += 1;
                x = 12;
                y = 12 + 10 + 80 * line;
            }
            else
            {
                x = 12 + 160 + 5;
            }

            rtb.Location = new System.Drawing.Point(x, y);
            rtb.Width = 160;
            rtb.Height = 80;
            return rtb;
        }
    }
}

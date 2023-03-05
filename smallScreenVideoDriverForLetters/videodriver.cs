using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace smallScreenVideoDriverForLetters
{
    public class videodriver
    {
        public videodriver() { }
        public char[,] videobuffer = new char[100,100];
        public Graphics g;
        public Form f;
        public void setG(ref Graphics pg) { this.g = pg;}
        public void setF(Form pf) { this.f = pf; }
        public Pen p = new Pen(Color.Black);
        public Brush b = new SolidBrush(Color.Black);   
        public Font fnt = new Font("Arial", 8);
        public void putCharIntoVideoBuffer(char c, int x, int y)
        {
            videobuffer[x,y] = c;
        }
        public void writeCharFromVideoBuffer(int x, int y) {
            g.DrawString(videobuffer[x, y].ToString(), fnt, b, x, y);
           

        }

        public void writeStringToBuffer(string s, int x, int y)
        {
            char[] chars = s.ToCharArray();
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                putCharIntoVideoBuffer(chars[ctr],x+ctr,y);
            }

            
           
        }

        public void writeStringFromVideoBuffer(int x1, int y1,int x2, int y2)
        {
            for (int i = x1; i <= x2; i++)
            {
                g.DrawString(videobuffer[i, y1].ToString(), fnt, b, i*8, y1);
            }

        }
    }
}

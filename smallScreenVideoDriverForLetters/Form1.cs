using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallScreenVideoDriverForLetters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics ig;

        public videodriver v = new videodriver();

        private void Form1_Load(object sender, EventArgs e)
        {
            ig = CreateGraphics();
            v.setG(ref ig);
            v.setF(this);


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            v.putCharIntoVideoBuffer('A', 1, 1);
            v.writeCharFromVideoBuffer(1, 1);
            v.writeStringToBuffer("alfabet", 3, 1);
            v.writeStringFromVideoBuffer(3,1,3+7,1);
        }
    }
}

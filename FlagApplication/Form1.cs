using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Infolabel.Text = "Twitter, Inc. is an American communications company based in San Francisco, California." +
                " The company operates the microblogging and social networking service Twitter. " +
                "It previously operated the Vine short video app and Periscope livestreaming service.";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Infolabel.Text = "An ebook is a book presented in a format that allows you to read it on an electronic device like a computer or handheld device. Several books that are available in printed versions can be found as ebooks.These include everything from bestselling fiction, classics to reference and academic texts.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Infolabel.Text = "A conference call is a telephone call in which someone talks to 4 or more people at the same time. The conference call may be designed to allow the called party to participate during the call or set up so that the called party merely listens into the call and cannot speak.";
        }
    }
}

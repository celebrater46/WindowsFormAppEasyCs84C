using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WindowsFormsAppEasyCs84C
{
    public partial class Form1 : Form
    {
        private Label lb;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Clock";
            this.Width = 250;
            this.Height = 100;

            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Start();

            lb = new Label();
            lb.Font = new Font("Courier", 20, FontStyle.Bold);
            lb.Dock = DockStyle.Fill;

            lb.Parent = this;

            tm.Tick += new EventHandler(TmTick);
        }

        public void TmTick(Object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lb.Text = dt.ToLongTimeString();
        }
    }
}
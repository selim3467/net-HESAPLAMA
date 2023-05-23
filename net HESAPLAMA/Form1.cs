using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_HESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double matdoru = Convert.ToDouble(txtmatematikdoru.Text);
            double matyanlis = Convert.ToDouble(txtmatematikyanlıs.Text);

            double turkcedoru = Convert.ToDouble(txtturkcedoru.Text);
            double turkceyanlis = Convert.ToDouble(txtturkceyanlıs.Text);

            double kimyadoru = Convert.ToDouble(txtkımyadoru.Text);
            double kimyayanlis = Convert.ToDouble(txtkımyayanlıs.Text);

            double fizikdoru = Convert.ToDouble(txtfızıkdoru.Text);
            double fizikyanlis = Convert.ToDouble(txtfızıkyanlıs.Text);

            double matnet = matdoru - (matyanlis / 4);
            double turknet = turkcedoru - (turkceyanlis / 4);
            double kimyanet = kimyadoru - (kimyayanlis / 4);
            double fiziknet = kimyadoru - (kimyayanlis / 4);


            txtmatnet.Text = matnet.ToString();
            txtturkcenet.Text = turknet.ToString();
            txtkımyanet.Text = kimyanet.ToString();
            txtfızıknet.Text = fiziknet.ToString();

            double net = Convert.ToDouble(matnet + turknet + kimyanet + fiziknet);
            txtsonuc.Text = net.ToString();

        }
    }
}

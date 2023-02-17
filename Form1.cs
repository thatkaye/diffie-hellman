using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diffie_hellman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private static long diffie(long a, long b, long P)
        {
            if (b == 1)
                return a;
            else
                return (((long)Math.Pow(a, b)) % P);
        }

        private void compute_Click(object sender, EventArgs e)
        {
            // check if prime
            string prime1 = prime1tb.Text;
            string prime2 = prime2tb.Text;

            if (!isprimenum(prime1tb.Text) && prime1tb.Text != "")
            {
                MessageBox.Show("please check if prime inputs are prime and secrets are numbers");
                prime1tb.Text = "";
            }
            else
                prime1tb.Text = prime1.ToString();

            
            if (!isprimenum(prime2tb.Text) && prime2tb.Text != "")
            {
                MessageBox.Show("please check if prime inputs are prime and secrets are numbers");
                prime2tb.Text = "";
            }
            else
                prime2tb.Text = prime2.ToString();

            long key1, key2, secretkey1, secretkey2;

            key1 = diffie(int.Parse(prime2tb.Text), int.Parse(secret1tb.Text), int.Parse(prime1tb.Text));
            key2 = diffie(int.Parse(prime2tb.Text), int.Parse(secret2tb.Text), int.Parse(prime1tb.Text));

            // generate secret key
            secretkey1 = diffie(key2, int.Parse(secret1tb.Text), int.Parse(prime1tb.Text));
            secretkey2 = diffie(key1, int.Parse(secret2tb.Text), int.Parse(prime1tb.Text));

            // key exchange complete
            if (secretkey1 == secretkey2)
                keytb.Text = secretkey1.ToString();
        }

        private bool isprimenum(string num)
        {
            int x = 0;
            bool isnum = int.TryParse(num, out x);

            if (!isnum)
                return false;
            else
            {
                int i;

                for (i = 2; i < int.Parse(num); i++)
                {
                    if (int.Parse(num) % i == 0)
                        return false;
                }

                return true;
            }
        }

        private bool isnum(string num)
        {
            int x = 0;
            bool isnum = int.TryParse(num, out x);

            if (!isnum)
                return false;
            else
                return true;
        }

        private void prime1tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void prime2tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void secret1tb_TextChanged(object sender, EventArgs e)
        {
            string secret1 = secret1tb.Text;

            if (!isnum(secret1tb.Text) && secret1tb.Text != "")
            {
                MessageBox.Show("only numbers are accepted");
                secret1tb.Text = "";
            }
            else
                secret1tb.Text = secret1.ToString();
        }

        private void secret2tb_TextChanged(object sender, EventArgs e)
        {
            string secret2 = secret2tb.Text;

            if (!isnum(secret2tb.Text) && secret2tb.Text != "")
            {
                MessageBox.Show("only numbers are accepted");
                secret2tb.Text = "";
            }
            else
                secret2tb.Text = secret2.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

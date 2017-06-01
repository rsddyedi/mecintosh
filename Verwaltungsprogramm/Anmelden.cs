using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verwaltungsprogramm
{
    public partial class anmelden : Form
    {   
        //variable declarations of stuff that will not change
        const string valid = "abcdefghijklmnopqrstuvwxyz0123456789";
        string[,] data = new string[,]{{"konstrukteur", "pass1"}, {"lagerist", "pass2"}, {"mitarbeiter", "pass3"}};
            
        public anmelden()
        {
            InitializeComponent();
            TBpassword.PasswordChar = '*';
        }

        private bool checkUser(string str)
        {
            if (str == "kostrukteur" || str == "lagerist" || str == "mitarbeiter")
            {
                return true;
            }
            return false;
        }

        private bool checkPass(string user, string pass)
        {
            if (user == "kostrukteuer" && pass == "pass1")
            {
                return true;
            }
            else if (user == "lagerist" && pass == "pass2")
            {
                return true;
            }
            else if (user == "mitarbeiter" && pass == "pass3")
            {
                return true;
            }
            return false;
        }

        private void BSFLanmelden_Click(object sender, EventArgs e)
        {
            string user = TBusername.Text.ToString(),
            pass = TBpassword.Text.ToString();

            bool typo = user.All(c => valid.Contains(c)),
            check1 = checkUser(user), check2 = false;

            if (typo)
            {
                MessageBox.Show("Ungültiges Zeichen eingegeben");
                reset();
            }
            else
            {
                if (check1) // Username check
                {
                    check2 = checkPass(user, pass);
                }

                if (check2)
                {
                    Hauptmenue menu = new Hauptmenue();
                    menu(user);
                }
            }
           
            
            
            
        }

        private void reset()
        {
            
        }
    }
}

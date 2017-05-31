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

        private bool checkArr(Array arr, string str)
        {
            int i = Array.IndexOf(arr, str);
            if(i < 0){
                return false;
            }
            else {
                return i;
            }
        }

        private void BSFLanmelden_Click(object sender, EventArgs e)
        {
            string user = TBusername.Text.ToString(),
            pass = TBpassword.Text.ToString();

            int userPos = Array.IndexOf(data, user),
            passPos = Array.IndexOf(data, pass);

            bool checkUser = dataUser && dataPass,
            validUser = user.All(c => valid.Contains(c));

            if(validUser){
                hauptmenue(user);
            }
        }
    }
}

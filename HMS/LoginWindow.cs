using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authentication;
using System.Collections;

namespace HMS
{
    public partial class LoginWindow : Sample1
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count > 0)
            {
                MainClass.showMessage("Fields with RED are mandatory.", "error");
            }
            else
            {
                Hashtable ht = new Hashtable();
                ht.Add("@username", userTxt.Text);
                ht.Add ("@pass", passwordTxt.Text);

                if(login.getLoginDetails("st_getAuthDetails", ht))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);
                }
                else
                {

                }
                 
            }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if(userTxt.Text == "") { userTxt.BackColor = Color.Firebrick; } else { userTxt.BackColor = Color.White; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { passwordTxt.BackColor = Color.Firebrick; } else { passwordTxt.BackColor = Color.White; }

        }
    }
}

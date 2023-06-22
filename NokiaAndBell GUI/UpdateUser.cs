using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NokiaAndBell_GUI.services;
using System.IO;

namespace NokiaAndBell_GUI
{
    public partial class UpdateUser : UserControl
    {
        public UpdateUser()
        {
            InitializeComponent();
            if(File.Exists("token.txt"))
            {
                var lines = File.ReadLines("token.txt");
                foreach (var line in lines)
                {
                    if (line.StartsWith("name"))
                    {
                        accountname.Text = line.Replace("name", "");
                    }
                    else if (line.StartsWith("accountconname"))
                    {
                        accountconname.Text = line.Replace("accountconname", "");
                    }
                    else if (line.StartsWith("accountconid"))
                    {
                        accountconid.Text = line.Replace("accountconid", "");
                    }
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var value = await UserUpdate.Run(usernameText.Text, passwordText.Text);
            accountname.Text = value.data.accountName;
            accountconname.Text = value.data.contractorName;
            accountconid.Text = value.data.contractorId.ToString();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("token.txt"))
            {
                file.WriteLine("name" + value.data.accountName);
                file.WriteLine("accountconname" + value.data.contractorName);
                file.WriteLine("accountconid" + value.data.contractorId.ToString());
                file.WriteLine("token" + value.data.token);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();

        private void registerUser_Click(object sender, EventArgs e)
        {
            string nameSurname = nameSurnameInput.Text;
            DateTime birthdate = DtBirthday.Value;
            string mobileNumber = mobileNumberInput.Text;

            if (nameSurname != string.Empty && mobileNumber != string.Empty)
            {
                User newUser = new User(nameSurname,birthdate,mobileNumber);
                users.Add(newUser);
                dgwUsers.Rows.Add(nameSurname, birthdate.ToString("dd.MM.yyyy"),mobileNumber);
                LblRegisterOutput.Text = nameSurname + " uğurla əlavə olundu.";
                resetTextboxes();
            }
            else
            {
                LblRegisterOutput.Text = "Bütün xanaları doldurun.";
            }
        }

        private void resetTextboxes()
        {
            nameSurnameInput.Text = string.Empty;
            DtBirthday.Value = DateTime.Now;
            mobileNumberInput.Text = string.Empty;
        }

        private void TxtSearchInput_TextChanged(object sender, EventArgs e)
        {
            string input = TxtSearchInput.Text;
            for (int i = 0; i < dgwUsers.RowCount; i++)
            {
                for (int j = 0; j  < dgwUsers.Rows[i].Cells.Count; j ++)
                {
                    if(dgwUsers.Rows[i].Cells[j].Value.ToString().Contains(input))
                    {
                        dgwUsers.Rows[i].Visible = true;q1
                    }
                    else
                    {
                        dgwUsers.Rows[i].Visible = false;
                    }
                }
            }
        }
    }
}

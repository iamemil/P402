using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace techStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillComputers();
        }

        private void fillComputers()
        {
            dgwComputers.Rows.Clear();

            SqlConnection dbConnect = new SqlConnection(@"Server= CACR11\SERVER2018; Database= TechStore;Integrated Security=SSPI;");
            dbConnect.Open();
            string getComputers = "SELECT * FROM Computers";

            SqlCommand getComputersCommand = new SqlCommand(getComputers, dbConnect);
            SqlDataReader computers = getComputersCommand.ExecuteReader();

            while (computers.Read())
            {
                dgwComputers.Rows.Add(computers.GetInt32(0), computers.GetString(1), computers.GetString(2), computers.GetDecimal(3), computers.GetString(4));
            }
            dbConnect.Close();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            string ComputerBrand = TxtCompBrand.Text;
            string ComputerModel = TxtComputerModel.Text;
            double ComputerDisplay = Convert.ToDouble(TxtComputerDisplay.Text);
            string ComputerRam = TxtComputerRam.Text + "GB";



            if (ComputerBrand != string.Empty && ComputerModel != string.Empty && TxtComputerDisplay.Text != string.Empty && TxtComputerRam.Text != string.Empty)
            {
                SqlConnection dbConnect = new SqlConnection(@"Server= CACR11\SERVER2018; Database= TechStore;Integrated Security=SSPI;");
                dbConnect.Open();
                string AddComputer = "INSERT INTO Computers([Brand],[Model],[Display],[RAM]) VALUES('" + ComputerBrand + "','" + ComputerModel + "','" + ComputerDisplay + "','" + ComputerRam + "')";

                SqlCommand AddComputerCommand = new SqlCommand(AddComputer, dbConnect);

                int CommandResult = AddComputerCommand.ExecuteNonQuery();

                if (CommandResult > 0)
                {
                    MessageBox.Show(ComputerBrand+" "+ ComputerModel+" added successfully.");
                    fillComputers();
                    ComputerBrand = "";
                    ComputerModel = "";
                    TxtComputerDisplay.Text = "";
                    ComputerRam = "";
                }

                dbConnect.Close();
            }
            else
            {
                MessageBox.Show("Fill All Blanks");
            }

        }
    }
}

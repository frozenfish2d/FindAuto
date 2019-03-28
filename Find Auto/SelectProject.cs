using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_Auto
{

    public partial class SelectProject : Form
    {
        public string connString;

        public SelectProject()
        {
            InitializeComponent();

            string querySites = "SELECT * FROM Sites";
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fish\source\repos\Find Auto\Find Auto\searchData.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd1 = new SqlCommand(querySites, connection);
                DataTable tbl1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(tbl1);
                comboBoxSite.DataSource = tbl1;
                comboBoxSite.DisplayMember = "sitename"; 
                comboBoxSite.ValueMember = "tableprefix";            
                comboBoxSite.SelectedIndex = -1;
                connection.Close();
            }
            /*
            string prefixString = comboBoxSite.SelectedValue.ToString();
            string queryBrands = "SELECT * FROM Brands" + prefixString + " ";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd2 = new SqlCommand(queryBrands, connection);
                DataTable tbl2 = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd2);
                data.Fill(tbl2);

                comboBoxBrand.DataSource = tbl2;
                comboBoxBrand.DisplayMember = "brandname";
                comboBoxBrand.ValueMember = "brandvalue";
                comboBoxBrand.SelectedIndex =-1;
                connection.Close();
            }*/


            comboBoxMinPrice.Items.Add("5000");
            comboBoxMinPrice.Items.Add("10000");
            comboBoxMaxPrice.Items.Add("16000");
            comboBoxMaxPrice.Items.Add("25000");

            // Fill Years comboBoxes
            for (int i=2020; i > 1901; i--)
            {
                comboBoxMinYear.Items.Add(i.ToString());
                comboBoxMaxYear.Items.Add(i.ToString());
            }


        }


        private void buttonSelect_Click(object sender, EventArgs e)
        {
            //openDialog.InitialDirectory = Application.CommonAppDataPath;
            //if (openDialog.ShowDialog() == DialogResult.Cancel || openDialog.ShowDialog() == DialogResult.Abort)
            //{
             //   
            //}
            
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            //Hide();

        }
        //при выборе друго сайта
        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Main mainForm = this.Owner as Main;
            //mainForm.siteId = comboBoxSite.SelectedIndex;
        }
        //При выборе другого Бренда
        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)//При выборе другого Бренда
        {
            
            //Main mainForm = this.Owner as Main;
            //mainForm.brandValue = comboBoxBrand.SelectedItem.ToString();
            //if ((comboBoxSite.SelectedIndex > -1) && (comboBoxBrand.SelectedIndex > -1))
            //{
            //    buttonCreateNew.Enabled = true;
            //}

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Main mainForm = this.Owner as Main;
            //mainForm.modelValue = comboBoxModel.SelectedItem.ToString();
            
        }

        private void comboBoxMinPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Main mainForm = this.Owner as Main;
            //mainForm.minPrice = comboBoxMinPrice.SelectedItem.ToString();

            
        }

        private void comboBoxMaxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Main mainForm = this.Owner as Main;
           //mainForm.maxPrice = comboBoxMaxPrice.SelectedItem.ToString();

            
        }

        private void comboBoxMinYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Main mainForm = this.Owner as Main;

            //mainForm.minYear = comboBoxMinYear.SelectedItem.ToString();

            
        }

        private void comboBoxMaxYear_SelectedValueChanged(object sender, EventArgs e)
        {
            //Main mainForm = this.Owner as Main;

            //mainForm.maxYear = comboBoxMaxYear.SelectedItem.ToString();
            
        }

        private void comboBoxMaxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {


            if (comboBoxBrand.SelectedValue.ToString() != "System.Data.DataRowView" && comboBoxBrand.SelectedValue.ToString() != null)
            {
                string prefixString = comboBoxSite.SelectedValue.ToString();
                string brandValue = comboBoxBrand.SelectedValue.ToString();

                string queryModels = "SELECT " +
                    "Models" + prefixString + ".modelname, " +
                    "Models" + prefixString + ".modelvalue, " +
                    "Models" + prefixString + ".brandid, " +
                    "Brands" + prefixString + ".brandvalue " +
                    "FROM " +
                    "Models" + prefixString + " " +
                    "INNER JOIN " +
                    "Brands" + prefixString + " ON " +
                    "Models" + prefixString + ".brandid=Brands" + prefixString + ".Id " +
                    "WHERE " +
                    "(Brands" + prefixString + ".brandvalue='" + brandValue + "') ";
                //MessageBox.Show(queryModels);
                comboBoxModel.DataSource = null;
                comboBoxModel.Items.Clear();
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand cmd2 = new SqlCommand(queryModels, connection);
                    DataTable tbl2 = new DataTable();
                    SqlDataAdapter data = new SqlDataAdapter(cmd2);
                    data.Fill(tbl2);
                    comboBoxModel.DataSource = tbl2;
                    comboBoxModel.DisplayMember = "modelname";
                    comboBoxModel.ValueMember = "modelvalue";
                    comboBoxModel.SelectedIndex = -1;
                    connection.Close();
                }
            }

        }

        private void comboBoxSite_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (comboBoxSite.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string prefixString = comboBoxSite.SelectedValue.ToString();
                string queryBrands = "SELECT * FROM Brands" + prefixString + " ";
                comboBoxBrand.DataSource = null;
                comboBoxBrand.Items.Clear();
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand cmd2 = new SqlCommand(queryBrands, connection);
                    DataTable tbl2 = new DataTable();
                    SqlDataAdapter data = new SqlDataAdapter(cmd2);
                    data.Fill(tbl2);
                    comboBoxBrand.DataSource = tbl2;
                    comboBoxBrand.DisplayMember = "brandname";
                    comboBoxBrand.ValueMember = "brandvalue";
                    comboBoxBrand.SelectedIndex = -1;
                    connection.Close();
                }
            }


        }
    }
}

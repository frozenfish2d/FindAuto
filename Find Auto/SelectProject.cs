using System;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Find_Auto
{

    public partial class SelectProject : Form
    {
        public string connString;
        int insertedId;

        public SelectProject()
        {
            InitializeComponent();
            string querySites = "SELECT * FROM Sites";
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Find Auto\Find Auto\searchData.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(querySites, connection);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                comboBoxSite.DataSource = dataTable;
                comboBoxSite.DisplayMember = "sitename"; 
                comboBoxSite.ValueMember = "tableprefix";            
                comboBoxSite.SelectedIndex = -1;
                connection.Close();
            }
            comboBoxMinPrice.Items.Add("1");
            comboBoxMinPrice.Items.Add("500");
            comboBoxMinPrice.Items.Add("1500");
            comboBoxMinPrice.Items.Add("2000");
            comboBoxMinPrice.Items.Add("2500");
            comboBoxMinPrice.Items.Add("3000");
            comboBoxMinPrice.Items.Add("4000");
            comboBoxMinPrice.Items.Add("5000");
            comboBoxMinPrice.Items.Add("6000");
            comboBoxMinPrice.Items.Add("7000");
            comboBoxMinPrice.Items.Add("8000");
            comboBoxMinPrice.Items.Add("9000");
            comboBoxMinPrice.Items.Add("10000");
            comboBoxMinPrice.Items.Add("12000");
            comboBoxMinPrice.Items.Add("14000");
            comboBoxMinPrice.Items.Add("16000");
            comboBoxMinPrice.Items.Add("18000");
            comboBoxMinPrice.Items.Add("20000");
            comboBoxMinPrice.Items.Add("25000");
            comboBoxMinPrice.Items.Add("30000");
            //-------------------------------
            comboBoxMaxPrice.Items.Add("1");
            comboBoxMaxPrice.Items.Add("500");
            comboBoxMaxPrice.Items.Add("1500");
            comboBoxMaxPrice.Items.Add("2000");
            comboBoxMaxPrice.Items.Add("2500");
            comboBoxMaxPrice.Items.Add("3000");
            comboBoxMaxPrice.Items.Add("4000");
            comboBoxMaxPrice.Items.Add("5000");
            comboBoxMaxPrice.Items.Add("6000");
            comboBoxMaxPrice.Items.Add("7000");
            comboBoxMaxPrice.Items.Add("8000");
            comboBoxMaxPrice.Items.Add("9000");
            comboBoxMaxPrice.Items.Add("10000");
            comboBoxMaxPrice.Items.Add("12000");
            comboBoxMaxPrice.Items.Add("14000");
            comboBoxMaxPrice.Items.Add("16000");
            comboBoxMaxPrice.Items.Add("18000");
            comboBoxMaxPrice.Items.Add("20000");
            comboBoxMaxPrice.Items.Add("25000");
            comboBoxMaxPrice.Items.Add("30000");
            comboBoxMaxPrice.Items.Add("35000");
            comboBoxMaxPrice.Items.Add("40000");
            comboBoxMaxPrice.Items.Add("45000");
            comboBoxMaxPrice.Items.Add("50000");

            // Fill Years comboBoxes
            for (int i=2020; i > 1901; i--)
            {
                comboBoxMinYear.Items.Add(i.ToString());
                comboBoxMaxYear.Items.Add(i.ToString());
            }
        }


        private void buttonSelect_Click(object sender, EventArgs e)
        {
            ShowSearches searchesForm = new ShowSearches();
            searchesForm.StartPosition = FormStartPosition.CenterScreen;
            searchesForm.TopMost = true;
            searchesForm.ShowDialog();

            //   openDialog.InitialDirectory = Application.CommonAppDataPath;
            //   if (openDialog.ShowDialog() == DialogResult.Cancel || openDialog.ShowDialog() == DialogResult.Abort)
            //   {
            //      
            //   }

        }

        private void comboBoxSite_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (comboBoxSite.SelectedValue.ToString() != null)
            {
                string prefixString = comboBoxSite.SelectedValue.ToString();
                string queryBrands = "SELECT * FROM Brands" + prefixString + " ";
                comboBoxBrand.DataSource = null;
                comboBoxBrand.Items.Clear();
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(queryBrands, connection);
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dataTable);
                    comboBoxBrand.DataSource = dataTable;
                    comboBoxBrand.DisplayMember = "brandname";
                    comboBoxBrand.ValueMember = "brandvalue";
                    comboBoxBrand.SelectedIndex = -1;
                }
            }
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            Main mainForm = this.Owner as Main;
            mainForm.searchId = insertedId;
            mainForm.siteId = comboBoxSite.SelectedIndex;
            if (comboBoxBrand.SelectedIndex >= 0)
                mainForm.brandValue = comboBoxBrand.SelectedValue.ToString();
            mainForm.brandName = comboBoxBrand.Text;
            if (comboBoxModel.SelectedIndex >= 0)
                mainForm.modelValue = comboBoxModel.SelectedValue.ToString();
            mainForm.modelName = comboBoxModel.Text;
            mainForm.minPrice = comboBoxMinPrice.Text;
            mainForm.maxPrice = comboBoxMaxPrice.Text;
            mainForm.minYear = comboBoxMinYear.Text;
            mainForm.maxYear = comboBoxMaxYear.Text;

            string sqlString = "INSERT INTO SavedSearches " +
                "(site, brand, model, minyear, maxyear, minprice, maxprice) " +
                "OUTPUT INSERTED.[Id] " +
                "VALUES ('" + comboBoxSite.SelectedIndex + "'," +
                "'" + mainForm.brandValue + "'," +
                "'" + mainForm.modelValue + "'," +
                "'" + comboBoxMinYear.Text + "'," +
                "'" + comboBoxMaxYear.Text + "'," +
                "'" + comboBoxMinPrice.Text + "'," +
                "'" + comboBoxMaxPrice.Text + "') " ;
            

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.OpenAsync();
                SqlCommand cmd = new SqlCommand(sqlString, connection);
                insertedId = (int) cmd.ExecuteScalar();
            }
            mainForm.searchId = insertedId;

            Hide();
        }


        private void comboBoxBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {

            
            if (comboBoxBrand.SelectedValue.ToString() != null)
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
                }               
            }

        }

    }
}

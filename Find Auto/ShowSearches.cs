using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_Auto
{
    public partial class ShowSearches : Form
    {
        string connString;

        public ShowSearches()
        {
            InitializeComponent();
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Find Auto\Find Auto\searchData.mdf;Integrated Security=True;Connect Timeout=30";
            GetSavedSearches().GetAwaiter();
        }

        private void ShowSearches_Activated(object sender, EventArgs e)
        {
            

        }

        private async Task GetSavedSearches()
        {
            dataGridSearches.Rows.Clear();
            string sqlQuery = "SELECT * FROM SavedSearches ORDER BY date DESC";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                await connection.OpenAsync();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    string siteName, year, price;
                    while (await reader.ReadAsync())
                    {
                        var searchId = reader.GetValue(0);
                        var siteId = reader.GetValue(1).ToString();
                        if (siteId == "0")
                        {
                            siteName = "nettiauto.fi";
                        }
                        else if (siteId == "1")
                        {
                            siteName = "kamux.fi";
                        }
                        else
                        {
                            siteName = "blablabla";
                        }
                        var brandName = reader.GetValue(2).ToString();
                        var modelName = reader.GetValue(3).ToString();
                        var tminYear = reader.GetValue(4).ToString();
                        var tmaxYear = reader.GetValue(5).ToString();
                        var tminPrice = reader.GetValue(6).ToString();
                        var tmaxPrice = reader.GetValue(7).ToString();
                        var date = reader.GetValue(8);

                        //year string
                        if ((tminYear == "") && (tmaxYear == ""))
                        {
                            year = "N/A";
                        }
                        else if ((tminYear == "") && (tmaxYear != ""))
                        {
                            year = "to " + tmaxYear;
                        }
                        else if ((tminYear != "") && (tmaxYear == ""))
                        {
                            year = "from "+tminYear;
                        }
                        else
                        {
                            year = tminYear + " - " + tmaxYear;
                        }
                        // price string
                        if ((tminPrice == "") && (tmaxPrice == ""))
                        {
                            price = "N/A";
                        }
                        else if ((tminPrice == "") && (tmaxPrice != ""))
                        {
                            price = "to "+tmaxPrice;
                        }
                        else if ((tminPrice != "") && (tmaxPrice == ""))
                        {
                            price = "from " + tminPrice;
                        }
                        else
                        {
                            price = tminPrice + " - " + tmaxPrice;
                        }

                        dataGridSearches.Rows.Add(
                            searchId,
                            date,
                            siteName,
                            brandName,
                            modelName,
                            year,
                            price
                            );

                    }
                }
                reader.Close();
            }
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            var _searchId = dataGridSearches.CurrentRow.Cells[0].Value;
            MessageBox.Show(_searchId.ToString());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var _searchId = dataGridSearches.CurrentRow.Cells[0].Value;
            string _deleteQuery = "DELETE FROM SavedSearches WHERE Id='"+ _searchId+"' ";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.OpenAsync();
                SqlCommand cmd = new SqlCommand(_deleteQuery, connection);
                cmd.ExecuteNonQuery();
            }
            GetSavedSearches().GetAwaiter();
        }
    }
}

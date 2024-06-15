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

namespace BANKMS
{
    public partial class CUSTOMER_LIST : Form
    {
        public CUSTOMER_LIST()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            string searchDateInput = dob.Value.ToString("yyyy-MM-dd");

            try
            {
                DBConnection conn = new DBConnection();
                conn.OpenConnection();


                SqlCommand command = new SqlCommand("GetCustomersByDate", conn.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SearchDate", searchDateInput);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Bind data to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No records found for the given date.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void CUSTOMER_LIST_Load(object sender, EventArgs e)
        {
            dob.Format = DateTimePickerFormat.Custom;
            dob.CustomFormat = "yyyy-MM-dd";

        }
    }
    }


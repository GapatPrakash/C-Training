using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            //RunExecuteScalar();
            //RunExecuteReader();          
            //AddCustomer();
            //UpdateCustomer(1);
            //DeleteCustomer(3);
            RunExecuteDatasetForExcel();
        }

        private void DeleteCustomer(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRASHANT-K\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "DELETE FROM [table] where id = " + id;

            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void UpdateCustomer(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRASHANT-K\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "UPDATE [table] SET FName = '" + txtFName.Text +"', LName = '" +txtLName.Text + "',City = '" +  txtCity.Text + "' where id = " + id;

            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void AddCustomer()
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRASHANT-K\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Select max(id) from [table]";
            int id = Int32.Parse(cmd.ExecuteScalar().ToString());
            id++;

            cmd.CommandText = "INSERT INTO [table] (id, FName,LName, City) VALUES ("+ id  + ",'"+ txtFName.Text +"','" +txtLName.Text +"','" + txtCity.Text + "')";

            cmd.ExecuteNonQuery();
            con.Close();
         
        }


        private void RunExecuteScalar()
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRASHANT-K\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True");
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText ="Select City from [table]";
                cmd.CommandType = CommandType.Text;

                var city = cmd.ExecuteScalar();
                txtResult.Text = city.ToString();
            }
        }

        private void RunExecuteDataset()
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRASHANT-K\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;         
            cmd.CommandText = "Select * from [table]";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dsCustomer = new DataSet();
            adapter.Fill(dsCustomer);

            dgResult.DataSource = dsCustomer;
            dgResult.DataMember = dsCustomer.Tables[0].TableName;
        }

        private void RunExecuteDatasetForExcel()
        {
             OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Customer.xls;Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'");

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from [Sheet1$]";

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dsCust1);
        
            dgResult.DataSource = dsCust1;
            dgResult.DataMember = dsCust1.Tables[0].TableName;
        }

        private void RunExecuteReader()
        {
            SqlConnection con = new SqlConnection(@"Data Source=PRASHANT-K\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True");
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from [table]";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    con.Close();
                    txtResult.Text = reader[1] + " " + reader[2];
                }
            }
        }
    }
}

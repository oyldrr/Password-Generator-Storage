using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Password_Generator___Storage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This function helps to retrieve data from mysql database
        public void getData()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=password;database=passwords";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string query = "select * from passwords.password order by id desc";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                listNames.DataSource = dt;
                listNames.DisplayMember = "Name";

                listPasswords.DataSource = dt;
                listPasswords.DisplayMember = "hashed";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // This function helps to delete data from mysql database
        public void deleteData(string password)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=password;database=passwords";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string query = "delete from passwords.password where hashed='" + password + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Data Deleted!","Succesfully!");
                getData();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // This function helps to generate a random password and insert into mysql database
        public string GeneratePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        // This button event calls to GeneratePassword function and does some proccesses
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string password = textPassword.Text;
            int length = Convert.ToInt32(numboxLength.Value);

            if (password == "")
            {
                MessageBox.Show("Please enter a name!", "Error");
            }
            else
            {
                string hashed = GeneratePassword(length);

                string title = "Password generated!";
                string message = "Generated password of " + password + ":\r\n" + hashed;
                MessageBox.Show(message, title);

                string myConnectionString = "server=127.0.0.1; uid=root; pwd=password; database=passwords";
                string query = "insert into passwords.password(Name,hashed) values('" + this.textPassword.Text + "','" + this.GeneratePassword(length) + "');";

                MySqlConnection conn = new MySqlConnection(myConnectionString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                }
                conn.Close();
                getData();

                textPassword.Text = ""; // Clearing the name input form
            }


        }

        // This button event helps to user copy a password in easy way
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if(listPasswords.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a password!", "Error");
            }
            else
            {
                string selected = listPasswords.GetItemText(listPasswords.SelectedItem);
                Clipboard.SetText(selected);

                string title = "Password copied!";
                string message = "Password copied to clipboard";
                MessageBox.Show(message, title);
            }
        }

        // This function calls itself when form loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        // This button event calls to deleteData function and does some proccesses
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listPasswords.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a password!", "Error");
            }
            else
            {
                deleteData(listPasswords.GetItemText(listPasswords.SelectedItem));
            }
        }
    }
}

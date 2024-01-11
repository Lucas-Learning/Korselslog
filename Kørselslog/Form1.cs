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

namespace Kørselslog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Brugerhåndtering_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-0CS600E5JI9;Initial Catalog=KørselslogDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (Navn, Nummerplade) VALUES (@Navn, @Nummerplade)", con);
            cmd.Parameters.AddWithValue("@Navn", txt_navn.Text);
            cmd.Parameters.AddWithValue("@Nummerplade", txt_nummerplade.Text);
            
            
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Fuldført");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-0CS600E5JI9;Initial Catalog=KørselslogDB;Integrated Security=True;Pooling=False");
            con.Open();
           

            SqlCommand cmd = new SqlCommand("UPDATE [Table] set Nummerplade=@Nummerplade WHERE Navn ='"+txt_rediNavn.Text+"'", con);
            cmd.Parameters.AddWithValue("@Navn", txt_rediNavn.Text);
            cmd.Parameters.AddWithValue("@Nummerplade", txt_rediNummerPlade.Text);


            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("opdateret");
            
           

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;  
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-0CS600E5JI9;Initial Catalog=KørselslogDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE [Table] where Navn=@Navn", con);
            cmd.Parameters.AddWithValue("@Navn", txt_SletBruger.Text);
           

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Slettet");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_tabellen_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-0CS600E5JI9;Initial Catalog=KørselslogDB;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Navn,Nummerplade from [Table]",con);
            SqlDataAdapter da =  new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

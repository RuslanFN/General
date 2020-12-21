using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;
namespace Cours_job
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Imm = INN.Text.ToString();
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM 'Abonent' WHERE INN =  '@ul'", db.GetConect());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = Imm;
            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            MessageBox.Show(Convert.ToString(table.Rows.Find(0)));
        }
    }
}

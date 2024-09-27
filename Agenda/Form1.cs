using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;password=root;database=lista;");
        MySqlCommand cmd = null;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO `contatos`(`nomePessoa`, `numero`, `ativo`) VALUES (@name, @num, 's');", conn);
                cmd.Parameters.AddWithValue("@name", txbName.Text);
                cmd.Parameters.AddWithValue("@num", txbNum.Text);
                if(cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("deu errado");
                }
                else
                {
                    MessageBox.Show("Deu certo");
                }
                conn.Close();
                cmd = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txbName.Text = string.Empty; 
                txbNum.Text = string.Empty;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}

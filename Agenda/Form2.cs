using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;password=root;database=lista;");
        MySqlCommand cmd = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            try
            {
                MySqlConnection conn1 = new MySqlConnection("server=127.0.0.1;user=root;password=root;database=lista;");
                conn1.Open();
                cbbExibir.DisplayMember = "nomePessoa";
                cbbExibir.ValueMember = "id"; 
                cmd = new MySqlCommand("SELECT `id`, `nomePessoa` FROM `contatos`;", conn1);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbbExibir.DataSource = dt;
                conn1.Close();
                cmd = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnDelete.Visible = true;
                lbView.Items.Clear();
                conn.Open();
                string id = cbbExibir.SelectedValue.ToString();
                
                cmd = new MySqlCommand("SELECT * FROM `contatos` WHERE `id`=@id AND `ativo`='s';", conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbView.Items.Add("Nome: " + dr[1] + ", Número: " + dr[2]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string puxarId = cbbExibir.SelectedValue.ToString();
                if(MessageBox.Show("Tem certeza que deseja apagar o contato?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("DELETE FROM `contatos` WHERE `id`=@id", conn);
                    cmd.Parameters.AddWithValue("@id", puxarId);
                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("erro ao apagar");
                    }
                    else
                    {
                        MessageBox.Show("Deletado com sucesso");
                    }
                } 
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd = null;
                conn.Close();
            }
        }
    }
}

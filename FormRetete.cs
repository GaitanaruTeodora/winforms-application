using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProiect
{
    public partial class FormRetete : Form
    {
        List<Reteta> listaRetete;
        String connectionString;
        OleDbConnection connection;


        public FormRetete()
        {
            listaRetete = new List<Reteta>();
            connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CabinetMedical.accdb";
            connection = new OleDbConnection(connectionString);
            InitializeComponent();
        }

        private void FormRetete_Load(object sender, EventArgs e)
        {
            dgvReteta.Rows.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM reteta";
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Reteta reteta = new Reteta( Convert.ToInt32(dataReader["ID"]), dataReader["Serie"].ToString(),
                        Convert.ToInt32(dataReader["NrReteta"]), Convert.ToDateTime(dataReader["DataReteta"]), dataReader["Parafa"].ToString(), dataReader["CNP"].ToString(), dataReader["Categorie"].ToString());

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvReteta);
                    row.Cells[0].Value = reteta.Serie;
                    row.Cells[1].Value = reteta.NrReteta;
                    row.Cells[2].Value = reteta.DataReteta.ToShortDateString();
                    row.Cells[3].Value = reteta.Parafa;
                    row.Cells[4].Value = reteta.Cnp; 
                    row.Cells[5].Value = reteta.Categorie;
                    row.Tag = reteta;

                    listaRetete.Add(reteta);
                    dgvReteta.Rows.Add(row);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void dgvReteta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReteta.SelectedRows.Count != 0)
            {
                Reteta reteta = (Reteta)dgvReteta.SelectedRows[0].Tag;
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}

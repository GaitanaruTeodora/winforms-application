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
        List<DetaliuReteta> listaDetalii;
        String connectionString;
        OleDbConnection connection;
        Reteta updateObj;
        static int cod;


        public FormRetete()
        {
            listaRetete = new List<Reteta>();
            listaDetalii = new List<DetaliuReteta>();
            connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CabinetMedical.accdb";
            connection = new OleDbConnection(connectionString);
            InitializeComponent();
        }

        private void incarcareDetaliu()
        {
            dgvDet.Rows.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM detaliuReteta";
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    DetaliuReteta detaliuR = new DetaliuReteta(Convert.ToInt32(dataReader["ID"]), Convert.ToInt32(dataReader["IdReteta"]), dataReader["CodW"].ToString(), dataReader["DenumireMedicament"].ToString(), Convert.ToInt32(dataReader["Cantitate"]));

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvDet);
                    //row.Cells[0].Value = detaliuR.IdReteta;
                    row.Cells[0].Value = detaliuR.CodW;
                    row.Cells[1].Value = detaliuR.DenumireMedicament;
                    row.Cells[2].Value = detaliuR.Cantitate;
                   
                    row.Tag = detaliuR;

                    listaDetalii.Add(detaliuR);
                    dgvDet.Rows.Add(row);
                }
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

        private void incarcareReteta()
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
                    Reteta reteta = new Reteta(Convert.ToInt32(dataReader["ID"]), dataReader["Serie"].ToString(),
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void FormRetete_Load(object sender, EventArgs e)
        {
            

            incarcareReteta();
            incarcareDetaliu();
        }

        private void dgvReteta_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReteta.SelectedRows.Count != 0)
            {
                updateObj = (Reteta)dgvReteta.SelectedRows[0].Tag;
                tbSerie.Text = updateObj.Serie;
                tbNr.Text = updateObj.NrReteta.ToString();
                tbData.Text = updateObj.DataReteta.ToShortDateString();
                tbParafa.Text = updateObj.Parafa;
                tbCNP.Text = updateObj.Cnp;
                comboCategorie.SelectedItem = updateObj.Categorie;

                tabControl.SelectTab(pgDetaliuReteta);
            }

           
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = connection;

                comanda.CommandText = "SELECT MAX(ID) FROM reteta";
                int cod = Convert.ToInt32(comanda.ExecuteScalar());
                Random random = new Random();
                comanda.CommandText = "INSERT INTO reteta VALUES(?,?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("Serie", OleDbType.Char, 255).Value = tbSerie.Text;
                comanda.Parameters.Add("NrReteta", OleDbType.Integer).Value = tbNr.Text;
                comanda.Parameters.Add("DataReteta", OleDbType.Date).Value = tbData.Text;
                comanda.Parameters.Add("Parafa", OleDbType.Char, 255).Value = tbParafa.Text;
                comanda.Parameters.Add("CNP",OleDbType.Char, 255).Value = tbCNP.Text;
                comanda.Parameters.Add("Categorie",OleDbType.Char, 255).Value = comboCategorie.Text;
                comanda.ExecuteNonQuery();
                btnAdaugareDetaliu.Enabled = true;
                btnModificareDetaliu.Enabled = true;
                btnGolireDetaliu.Enabled = true;
                tbCod.Enabled = true;
                tbDenumireMed.Enabled = true;
                tbCantitate.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //tbSerie.Clear();
                //tbNr.Clear();
                //tbData.Clear();
                //tbParafa.Clear();
                //tbCNP.Clear();
                //comboCategorie.SelectedItem = null;
                connection.Close();
                incarcareReteta();
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            if (verificaExistenta(updateObj.Id) == true)
            {
                try
                {
                    connection.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = connection;

                    comanda.CommandText = "UPDATE reteta " +
                        "SET Serie = @Serie, " +
                        "NrReteta = @NrReteta," + "DataReteta = @DataReteta," + "Parafa = @Parafa," + "CNP = @CNP," + "Categorie = @Categorie where ID = @ID";
                    comanda.Parameters.Add("@Serie", OleDbType.Char, 255).Value = tbSerie.Text;
                    comanda.Parameters.Add("@NrReteta", OleDbType.Integer).Value = tbNr.Text;
                    comanda.Parameters.Add("@DataReteta", OleDbType.Date).Value = tbData.Text;
                    comanda.Parameters.Add("@Parafa", OleDbType.Char, 255).Value = tbParafa.Text;
                    comanda.Parameters.Add("@CNP", OleDbType.Char, 255).Value = tbCNP.Text;
                    comanda.Parameters.Add("@Categorie", OleDbType.Char, 255).Value = comboCategorie.Text;
                    comanda.Parameters.Add("@ID", OleDbType.Integer).Value = updateObj.Id;
                    comanda.ExecuteNonQuery();
                    tabControl.SelectTab(pgReteta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    
                    updateObj = null;
                    tbSerie.Clear();
                    tbNr.Clear();
                    tbData.Clear();
                    tbParafa.Clear();
                    tbCNP.Clear();
                    comboCategorie.SelectedItem = null;
                    connection.Close();
                    incarcareReteta();
                }
            }
        }

        private bool verificaExistenta(int id)
        {
            bool esteInBaza = false;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM reteta WHERE ID=" + id;
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0) esteInBaza = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return esteInBaza;
        }

        private void dgvReteta_Click(object sender, EventArgs e)
        {

        }

        private void dgvReteta_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && dgvReteta.SelectedRows.Count > 0)
            {
                Reteta reteta = (Reteta)dgvReteta.SelectedRows[0].Tag;
                try
                {
                    connection.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = connection;
                    comanda.CommandText = "DELETE FROM reteta WHERE ID=" + reteta.Id;
                    comanda.ExecuteNonQuery();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    incarcareReteta();
                }
            }
        }

        private void btnGolire_Click(object sender, EventArgs e)
        {
            tbSerie.Clear();
            tbNr.Clear();
            tbData.Clear();
            tbParafa.Clear();
            tbCNP.Clear();
            comboCategorie.SelectedItem = null;
        }

        private void btnModifiareDetaliu_Click(object sender, EventArgs e)
        {
            if (verificaExistenta(updateObj.Id) == true)
            {
                try
                {
                    connection.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = connection;

                    comanda.CommandText = "UPDATE detaliuReteta " +
                        "SET codW = @codW, " +
                        "denumireMedicament = @denumireMedicament," + "Cantitate = @Cantitate where ID = @ID";
                    comanda.Parameters.Add("@codW", OleDbType.Char, 255).Value = tbCod.Text;
                    comanda.Parameters.Add("@denumireMedicament", OleDbType.Char, 255).Value = tbDenumireMed.Text;
                    comanda.Parameters.Add("@Cantitate", OleDbType.Integer).Value = tbCantitate.Text;
                   
                    comanda.Parameters.Add("@ID", OleDbType.Integer).Value = updateObj.Id;
                    comanda.ExecuteNonQuery();
                    tabControl.SelectTab(pgReteta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    updateObj = null;
                    tbCod.Clear();
                    tbDenumireMed.Clear();
                    tbCantitate.Clear();
                    connection.Close();
                    incarcareDetaliu();
                }
            }
        }

        private void btnAdaugareDetaliu_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = connection;

                comanda.CommandText = "SELECT MAX(ID) FROM detaliuReteta";
                int cod2 = Convert.ToInt32(comanda.ExecuteScalar());
                Random random = new Random();
                comanda.CommandText = "INSERT INTO detaliuReteta VALUES(?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = cod2 + 1;
                comanda.Parameters.Add("IdReteta", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("CodW", OleDbType.Char, 255).Value = tbCod.Text;
                comanda.Parameters.Add("DenumireMedicament", OleDbType.Char, 255).Value = tbDenumireMed.Text;
                comanda.Parameters.Add("Cantitate", OleDbType.Integer).Value = tbCantitate.Text;
                
                comanda.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbDenumireMed.Clear();
                tbCantitate.Clear();
                connection.Close();
                incarcareDetaliu();
            }
        }
    }
}

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
        DetaliuReteta updateObj2;
        static int cod;
        static string scod;


        public FormRetete()
        {
            listaRetete = new List<Reteta>();
            listaDetalii = new List<DetaliuReteta>();
            connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CabinetMedical.accdb";
            connection = new OleDbConnection(connectionString);
            InitializeComponent();
        }

        private void incarcareDetaliu(int id)
        {
            dgvDet.Rows.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM detaliuReteta where IdReteta = " + id.ToString();
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    DetaliuReteta detaliuR = new DetaliuReteta(Convert.ToInt32(dataReader["ID"]), Convert.ToInt32(dataReader["IdReteta"]), dataReader["CodW"].ToString(), dataReader["DenumireMedicament"].ToString(), Convert.ToInt32(dataReader["Cantitate"]));

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvDet);
                    //row.Cells[0].Value = detaliuR.IdReteta;
                    row.Cells[0].Value = detaliuR.ID;
                    row.Cells[1].Value = detaliuR.IdReteta;
                    row.Cells[2].Value = detaliuR.CodW;
                    row.Cells[3].Value = detaliuR.DenumireMedicament;
                    row.Cells[4].Value = detaliuR.Cantitate;

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
                    row.Cells[0].Value = reteta.ID;
                    row.Cells[1].Value = reteta.Serie;
                    row.Cells[2].Value = reteta.NrReteta;
                    row.Cells[3].Value = reteta.DataReteta.ToShortDateString();
                    row.Cells[4].Value = reteta.Parafa;
                    row.Cells[5].Value = reteta.Cnp;
                    row.Cells[6].Value = reteta.Categorie;
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
            incarcareDetaliu(1);
            panel2.Enabled = false;
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
                panel1.Enabled = true;
                panel2.Enabled = false;
                btnAdauga.Enabled = false;
                btnModificare.Enabled = true;
                btnAdaugareDetaliu.Enabled = true;
                btnModificareDetaliu.Enabled = false;
                tbCod.Clear();
                tbDenumireMed.Clear();
                tbCantitate.Clear();

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
                cod = Convert.ToInt32(comanda.ExecuteScalar());
                Random random = new Random();
                comanda.CommandText = "INSERT INTO reteta VALUES(?,?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("Serie", OleDbType.Char, 255).Value = tbSerie.Text;
                comanda.Parameters.Add("NrReteta", OleDbType.Integer).Value = tbNr.Text;
                comanda.Parameters.Add("DataReteta", OleDbType.Date).Value = tbData.Text;
                comanda.Parameters.Add("Parafa", OleDbType.Char, 255).Value = tbParafa.Text;
                comanda.Parameters.Add("CNP", OleDbType.Char, 255).Value = tbCNP.Text;
                comanda.Parameters.Add("Categorie", OleDbType.Char, 255).Value = comboCategorie.Text;
                comanda.ExecuteNonQuery();
                panel2.Enabled = true;
                btnAdaugareDetaliu.Enabled = true;
                btnModificareDetaliu.Enabled = false;
                btnGolireDetaliu.Enabled = true;


            }
            catch (Exception ex)
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
                tbCod.Focus();
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            if (verificaExistenta(updateObj.ID) == true)
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
                    comanda.Parameters.Add("@ID", OleDbType.Integer).Value = updateObj.ID;
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
        private bool verificaExistenta2(int id)
        {
            bool esteInBaza = false;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM detaliuReteta WHERE ID=" + id;
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

        private void btnGolire_Click(object sender, EventArgs e)
        {
            tbSerie.Clear();
            tbNr.Clear();
            tbData.Clear();
            tbParafa.Clear();
            tbCNP.Clear();
            comboCategorie.SelectedItem = null;
            btnAdauga.Enabled = true;
            btnModificare.Enabled = false;
            panel2.Enabled = false;

        }

        private void btnModifiareDetaliu_Click(object sender, EventArgs e)
        {
            
            if (verificaExistenta2(updateObj2.ID) == true)
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

                    comanda.Parameters.Add("@ID", OleDbType.Integer).Value = updateObj2.ID;
                    comanda.ExecuteNonQuery();
                    tabControl.SelectTab(pgReteta);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    updateObj2 = null;
                    tbCod.Clear();
                    tbDenumireMed.Clear();
                    tbCantitate.Clear();
                    connection.Close();
                    incarcareDetaliu(listaRetete[0].ID);
                    
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
                incarcareDetaliu(listaRetete[0].ID);
                
                
                DialogResult dr = MessageBox.Show("Adaugati urmatorul medicament?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    tbCod.Focus();
                } else
                {
                    tabControl.SelectTab(pgReteta);
                }
            }
        }

        private void dgvReteta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int id = listaRetete[e.RowIndex].ID;
            //incarcareDetaliu(id);
        }

        private void dgvDet_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDet.SelectedRows.Count != 0)
            {
                updateObj2 = (DetaliuReteta)dgvDet.SelectedRows[0].Tag;
                tbCod.Text = updateObj2.CodW;
                tbCantitate.Text = updateObj2.Cantitate.ToString();
                tbDenumireMed.Text = updateObj2.DenumireMedicament;

                tabControl.SelectTab(pgDetaliuReteta);
                panel1.Enabled = false;                
                panel2.Enabled = true;
                btnAdaugareDetaliu.Enabled = false;
                btnAdauga.Enabled = false;
                btnModificareDetaliu.Enabled = true;
                tbSerie.Clear();
                tbNr.Clear();
                tbData.Clear();
                tbParafa.Clear();
                tbCNP.Clear();
                comboCategorie.SelectedItem = null;

            }

        }

        private void dgvDet_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cod = Convert.ToInt32(dgvDet.Rows[e.RowIndex].Cells[0].Value.ToString());
            int icod = Convert.ToInt32(dgvDet.Rows[e.RowIndex].Cells[1].Value.ToString());
            scod = dgvDet.Rows[e.RowIndex].Cells[0].Value.ToString();
            string scodmed = dgvDet.Rows[e.RowIndex].Cells[2].Value.ToString();
            DialogResult dr = MessageBox.Show("Stergem medicamentul " + scodmed + "? ", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = connection;
                    comanda.CommandText = "DELETE FROM DetaliuReteta WHERE ID=" + scod;
                    comanda.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    incarcareDetaliu(icod);
                }

            }
        }

        private void dgvReteta_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            scod = dgvReteta.Rows[e.RowIndex].Cells[0].Value.ToString();
            string scodmed = dgvReteta.Rows[e.RowIndex].Cells[2].Value.ToString();
            DialogResult dr = MessageBox.Show("Stergem reteta " + scodmed + "? ", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                connection.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = connection;
                comanda.CommandText = "DELETE FROM Reteta WHERE ID=" + scod;
                comanda.ExecuteNonQuery();
                connection.Close();
                dgvReteta.MultiSelect = false;
                dgvReteta.MultiSelect = true;
                //dgvReteta.Rows.RemoveAt(dgvReteta.SelectedRows[0].Index);
                connection.Open();
                OleDbCommand comanda2 = new OleDbCommand();
                comanda2.Connection = connection;
                comanda2.CommandText = "DELETE FROM DetaliuReteta WHERE IdReteta=" + scod;
                comanda2.ExecuteNonQuery();
                connection.Close();

                dgvReteta.MultiSelect = false;
                dgvReteta.MultiSelect = true;

                incarcareReteta();
                incarcareDetaliu(1);

            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.Controls[1] == tabControl.SelectedTab)
            {
                
                //incarcareReteta();
                //incarcareDetaliu(1);
            }
            
        }

        private void btnGolireDetaliu_Click(object sender, EventArgs e)
        {
            btnModificareDetaliu.Enabled = false;
            btnAdaugareDetaliu.Enabled = true;
            tbCod.Clear();
            tbDenumireMed.Clear();
            tbCantitate.Clear();
            panel1.Enabled = true;
            panel2.Enabled = false;
            btnGolire.Enabled = true;
            btnAdauga.Enabled = true;
            btnModificare.Enabled = false;

            
        }

        private void dgvReteta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int icod = Convert.ToInt32(dgvReteta.Rows[e.RowIndex].Cells[0].Value.ToString());
           
           // MessageBox.Show(icod);
            incarcareDetaliu(icod);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}

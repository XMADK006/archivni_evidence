using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KM1.Properties;

namespace KM1
{
    public partial class Databaze : Form
    {
        public Databaze()
        {
            InitializeComponent();
        }

        Evidence c = new Evidence();
        static string myconstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void Databaze_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgEvidenceList.DataSource = dt;
        }

        //Vymaž všechna pole v levé časti GUI po stisknutí tlačítka Storno
        private void buttonStorno_Click(object sender, EventArgs e)
        {
            VymazPole();
        }

        // Přidej řádek do databáze po stisknutí tlačítka Přidej
        private void buttonPridat_Click(object sender, EventArgs e)
        {
            //přidání hodnoty z inputu
            c.archivniFond = txtBoxFond.Text;
            c.puvodce = txtBoxPuvodce.Text;
            c.zpracovany = cmbBoxZpracovany.Text;
            c.pomucka = cmbBoxPomucka.Text;
            c.rokZaevidovani = int.Parse(numericUpDownRok.Value.ToString());

            //vložení dat do databáze
            bool success = c.Insert(c);
            if (success == true)
            {
                //úspěšně vloženo
                MessageBox.Show("Nový záznam byl úspěšně vložen.");
                VymazPole();
            }
            else
            {
                //vložení bylo neúspěšné
                MessageBox.Show("Vložení záznamu se nezdařilo.");
            }
            DataTable dt = c.Select();
            dgEvidenceList.DataSource = dt;
        }

        // Vymaž všechna pole v levé části GUI
        public void VymazPole()
        {
            txtBoxNAD.Text = "";
            txtBoxFond.Text = "";
            txtBoxPuvodce.Text = "";
            cmbBoxZpracovany.Text = "";
            cmbBoxPomucka.Text = "";
            numericUpDownRok.Value = 1900;
        }
        // Hodnoty vybraného řádku databáze zkopíruj do jednotlivých polí v levé části GUI 
        private void dgEvidenceList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // Získej data z Data Gridu a vlož je do jednotlivých políček; řádek se vybere myší
                int rowIndex = e.RowIndex;
                txtBoxNAD.Text = dgEvidenceList.Rows[rowIndex].Cells[0].Value.ToString();
                txtBoxFond.Text = dgEvidenceList.Rows[rowIndex].Cells[1].Value.ToString();
                txtBoxPuvodce.Text = dgEvidenceList.Rows[rowIndex].Cells[2].Value.ToString();
                cmbBoxZpracovany.Text = dgEvidenceList.Rows[rowIndex].Cells[3].Value.ToString();
                cmbBoxPomucka.Text = dgEvidenceList.Rows[rowIndex].Cells[4].Value.ToString();
                numericUpDownRok.Value = int.Parse(dgEvidenceList.Rows[rowIndex].Cells[5].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nelze vymazat!");
            }
        }

        // Změň řádek v databázi po stisknutí tlačítka Editovat
        private void buttonEditovat_Click(object sender, EventArgs e)
        {
            // Pokud je obsazeno číslo (tj. primární klíč) v políčku Číslo NAD, pak mohu editovat daný řádek
            if (txtBoxNAD.Text.Length > 0)
            {
                c.cisloNAD = int.Parse(txtBoxNAD.Text);
                c.archivniFond = txtBoxFond.Text;
                c.puvodce = txtBoxPuvodce.Text;
                c.zpracovany = cmbBoxZpracovany.Text;
                c.pomucka = cmbBoxPomucka.Text;
                c.rokZaevidovani = int.Parse(numericUpDownRok.Value.ToString());
                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Záznam se úspěšně změnil!");

                    DataTable dt = c.Select();
                    dgEvidenceList.DataSource = dt;

                    VymazPole();
                }
                else
                {
                    MessageBox.Show("Záznam se nepodařilo změnit!");

                }
            }
        }

        // Vymaž řádek v databázi po stisknutí tlačítka Vymazat
        private void buttonVymazat_Click(object sender, EventArgs e)
        {
            // Pokud je obsazeno číslo (tj. primární klíč), v políčku Číslo NAD pak mohu vymazat daný řádek
            if (txtBoxNAD.Text.Length > 0)
            {
                c.cisloNAD = int.Parse(Convert.ToString(txtBoxNAD.Text));
                bool success = c.Delete(c);
                if (success == true)
                {
                    MessageBox.Show("Výmaz byl úspěšný.");
                    DataTable dt = c.Select();
                    dgEvidenceList.DataSource = dt;

                    VymazPole();

                }
                else
                {
                    MessageBox.Show("Výmaz nebyl úspěšný.");
                }
            }
            else
            {
                MessageBox.Show("Nelze mazat řádek, pokud není vybrán!");
            }
        }


        // Vyhledej řádky v databázi, které obsahují ve sloupci ArchivniFond zadaný řetězec 
        private void textBoxVyhledat_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstr);
            try
            {
                string keyword = textBoxVyhledat.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_archiv where ArchivniFond like '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgEvidenceList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při vyhledávání!");

            }
            finally
            {
                conn.Close();
            }
        }

        // Vyhledej řádky v databázi, které obsahují ve sloupci Puvodce zadaný řetězec 
        private void textBoxVyhledatPuvodce_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstr);
            try
            {
                string keyword = textBoxVyhledatPuvodce.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_archiv where Puvodce like '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgEvidenceList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při vyhledávání!");

            }
            finally
            {
                conn.Close();
            }
        }

        // Vyhledej řádky v databázi, které obsahují ve sloupci Zpracovany zadaný řetězec 
        private void textBoxVyhledatZpracovani_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstr);
            try
            {
                string keyword = textBoxVyhledatZpracovani.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_archiv where Zpracovany like '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgEvidenceList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při vyhledávání!");

            }
            finally
            {
                conn.Close();
            }
        }

        // Vyhledej řádky v databázi, které obsahují ve sloupci Pomucka zadaný řetězec 
        private void textBoxVyhledatPomucka_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstr);
            try
            {
                string keyword = textBoxVyhledatPomucka.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_archiv where Pomucka like '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgEvidenceList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při vyhledávání!");
            }
            finally
            {
                conn.Close();
            }
        }

        // Vyhledej řádky v databázi, které obsahují ve sloupci RokZaevidovani zadaný řetězec 
        private void textBoxVyhledatZaevidovani_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstr);
            try
            {
                string keyword = textBoxVyhledatZaevidovani.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_archiv where RokZaevidovani like '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgEvidenceList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při vyhledávání!");

            }
            finally
            {
                conn.Close();
            }
        }

        // Vyhledej řádky v databázi, které obsahují zadaný řetězec v jakémkoliv sloupci 
        private void textBoxVyhledatVsude_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstr);
            try
            {
                c.archivniFond = txtBoxFond.Text;
                c.puvodce = txtBoxPuvodce.Text;
                c.zpracovany = cmbBoxZpracovany.Text;
                c.pomucka = cmbBoxPomucka.Text;
                c.rokZaevidovani = int.Parse(numericUpDownRok.Value.ToString());

                string keyword = textBoxVyhledatVsude.Text;
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_archiv where ArchivniFond like '%" + keyword + "%' or Puvodce like '%" + keyword + "%' or Zpracovany like '%" + keyword + "%' or Pomucka like '%" + keyword + "%' or R" +
                    "okZaevidovani like '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgEvidenceList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při vyhledávání!");

            }
            finally
            {
                conn.Close();
            }
        }
    }
}

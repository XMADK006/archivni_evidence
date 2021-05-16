using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KM1.Properties
{
    public class Evidence
    {
        //nastavení getter, setter
        public int cisloNAD { get; set; }
        public string archivniFond { get; set; }
        public string puvodce { get; set; }
        public string zpracovany { get; set; }
        public string pomucka { get; set; }
        public int rokZaevidovani { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Tato metoda byla vytvořena pro potřeby unit testu

        public static bool JeUspech(int rows)
        {
            bool jeUspech = false;
            if (rows > 0)
            {
                jeUspech = true;
            }
            else
            {
                jeUspech = false;
            }
            return jeUspech;
        }

        //Výběr dat z databáze
        public DataTable Select()
        {
            //Spojení s databází
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //SQL Query
                string sql = "SELECT * FROM tbl_archiv";
                //Vytvoření cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Vytvoření SQL DataAdapter využívající cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při práci s databází!");

            }
            finally
            {
                //Zavři spojení
                conn.Close();
            }
            return dt;
        }

        //Vlož data do databáze
        public bool Insert(Evidence c)
        {
            //vytvoření dafaultního návratového typu a nastavení jeho hodnoty na false
            bool isSuccess = false;

            //připojení databáze
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //vytvoření SQL Query pro vložení dat
                string sql = "INSERT INTO tbl_archiv (ArchivniFond, Puvodce, Zpracovany, Pomucka, RokZaevidovani) VALUES (@ArchivniFond, @Puvodce, @Z" +
                    "pracovany, @Pomucka, @RokZaevidovani)";
                //vytvoření SQL příkazu použitím sql a conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //vytvoření parametrů pro vložení dat
                cmd.Parameters.AddWithValue("@ArchivniFond", c.archivniFond);
                cmd.Parameters.AddWithValue("@Puvodce", c.puvodce);
                cmd.Parameters.AddWithValue("@Zpracovany", c.zpracovany);
                cmd.Parameters.AddWithValue("@Pomucka", c.pomucka);
                cmd.Parameters.AddWithValue("@RokZaevidovani", c.rokZaevidovani);

                //spojení Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //pokud dotaz úspěšně běží, potom počet vložených řádků bude větší než 0 (v našem případě 1), v opačném případě bude počet vložených řádků 0
                isSuccess = JeUspech(rows);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při práci s databází!");

            }
            finally
            {
                //Zavři spojení
                conn.Close();
            }
            return isSuccess;
        }
        //Změň data v databázi
        public bool Update(Evidence c)
        {
            //vytvoření návratového datového typu a nastavení defaultní hodnoty na false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL změní data v databázi
                string sql = "UPDATE tbl_archiv SET ArchivniFond=@ArchivniFond, Puvodce=@Puvodce, Zpracovany=@Zpracovany, Pomucka=@Pomucka, RokZaevidovani=@RokZaevidovani WHERE cisloNAD=@cisloNAD";

                //vytvoření příkazu SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                //vytvoření parametrů pro vložení hodnoty
                cmd.Parameters.AddWithValue("@cisloNAD", c.cisloNAD);
                cmd.Parameters.AddWithValue("@ArchivniFond", c.archivniFond);
                cmd.Parameters.AddWithValue("@Puvodce", c.puvodce);
                cmd.Parameters.AddWithValue("@Zpracovany", c.zpracovany);
                cmd.Parameters.AddWithValue("@Pomucka", c.pomucka);
                cmd.Parameters.AddWithValue("@RokZaevidovani", c.rokZaevidovani);
                //otevření komunikace s databází
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //pokud dotaz úspěšně běží, potom počet změněných řádků bude větší než 0 (v našem případě 1), v opačném případě bude počet změněných řádků 0
                isSuccess = JeUspech(rows);
                }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při práci s databází!");
            }
            finally
            {
                //Zavři spojení
                conn.Close();
            }
            return isSuccess;
        }
        //Vymaž data z databáze
        public bool Delete(Evidence c)
        {
            //vytvoření defaultní návratové hodnoty a nastavení její hodnoty na false
            bool isSuccess = false;
            //vytvoření SQL spojení
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL dotaz pro vymazání dat
                string sql = "DELETE FROM tbl_archiv WHERE cisloNAD=@cisloNAD";

                //vytvoření SQL příkazu
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cisloNAD", c.cisloNAD);
                //otevření komunikace s databází
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //pokud dotaz úspěšně běží, potom počet vymazaných řádků bude větší než 0 (v našem případě 1), v opačném případě bude počet vymazaných řádků 0
                isSuccess = JeUspech(rows);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo k chybě při práci s databází!");

            }
            finally
            {
                //Zavři spojení
                conn.Close();
            }
            return isSuccess;
        }
    }
}

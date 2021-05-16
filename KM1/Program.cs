using System.Windows.Forms;

namespace KM1
{
    static class Program
    {

        // Spoustěcí část programu
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Databaze());

        }
    }
}

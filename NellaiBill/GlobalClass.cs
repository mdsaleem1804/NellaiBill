using System.Windows.Forms;

namespace NellaiBill
{
    public class GlobalClass
    {

        public GlobalClass()
        {

        }
        public  string DoFormat(double myNumber)
        {
            return string.Format("{0:0.00}", myNumber);
        }
        public string GetReportPath()
        {
            //return "E:\\Dotnet\\NellaiBill\\NellaiBill\\CrystalReports\\";
           // return "D:\\Saleem\\reports\\";
            return System.Windows.Forms.Application.StartupPath + "\\CrystalReports\\";
        }
        public void DisplayMessage(string xMessage)
        {
            MessageBox.Show(xMessage);
        }
        public void AcceptOnlyNumeric(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

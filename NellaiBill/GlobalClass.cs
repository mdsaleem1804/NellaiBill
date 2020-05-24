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
            return "E:\\Dotnet\\NellaiBill\\NellaiBill\\CrystalReports\\";
            //return System.Windows.Forms.Application.StartupPath + "\\CrystalReports\\" ;
        }

    }
}

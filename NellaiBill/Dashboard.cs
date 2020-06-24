using Google.Protobuf.WellKnownTypes;
using NellaiBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
namespace NellaiBill
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PrintReceiptPage(sender, e);
        }
        private static void PrintReceiptPage(object sender, EventArgs e)
        {


            float x = 10;
            float y = 5;
            float width = 170.0F; // max width I found through trial and error    
            float height = 0F;

            Font drawFontArial12Bold = new Font("Arial", 10, FontStyle.Bold);
            Font drawFontArial11Regular = new Font("Arial", 8, FontStyle.Regular);
            Font drawFontArial7Regular = new Font("Arial", 8, FontStyle.Regular);
            Font drawFontArial7Italic = new Font("Arial", 8, FontStyle.Italic);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Set format of string.    
            StringFormat drawFormatCenter = new StringFormat();
            drawFormatCenter.Alignment = StringAlignment.Center;
            StringFormat drawFormatLeft = new StringFormat();
            drawFormatLeft.Alignment = StringAlignment.Near;
            StringFormat drawFormatRight = new StringFormat();
            drawFormatRight.Alignment = StringAlignment.Far;

            // Draw string to screen.    

            //string text = "T.R. LAD S.P.";
            //e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            //text = "22. BRIGADE VRS, Kotor Varoš";
            //e.Graphics.DrawString(text, drawFontArial7Italic, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial7Italic).Height;

            //text = "- MALOPRODAJNI RACUN -\n";
            //e.Graphics.DrawString(text, drawFontArial11Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial11Regular).Height;



            //text = " ";
            //e.Graphics.DrawString(text, drawFontArial11Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial11Regular).Height;
            //text = " ";
            //e.Graphics.DrawString(text, drawFontArial11Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial11Regular).Height;


            //text = " ";
            //e.Graphics.DrawString(text, drawFontArial11Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial11Regular).Height;


            ///////
            //e.Graphics.DrawString(text, drawFontArial11Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial11Regular).Height;

            ////text = osobaFirma;    
            ////e.Graphics.DrawString(text, drawFontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);    
            ////y += e.Graphics.MeasureString(text, drawFontArial7Regular).Height;    


            //text = "----------------------------------------";
            //e.Graphics.DrawString(text, drawFontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial7Regular).Height;

            //text = "Datum: " + DateTime.Now.ToString();
            //e.Graphics.DrawString(text, drawFontArial7Italic, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial7Italic).Height;



            //text = "----------------------------------------";
            //e.Graphics.DrawString(text, drawFontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial7Regular).Height;


            //text = "HVALA VAM NA POSJETI";
            //e.Graphics.DrawString(text, drawFontArial7Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += e.Graphics.MeasureString(text, drawFontArial7Regular).Height;

            //string xCompanyName = "TEST";
            //string xCompanyAddress = "TEST ADDRESS";
            //string someText = xCompanyName + "\n " + xCompanyAddress + "\n" + "C# Corner is a community of software and data developers";
            //File.WriteAllText(@"C:\Users\Welcome\Desktop\backup\csc.txt", someText);
            //// Read a file  
            //string readText = File.ReadAllText(@"C:\Users\Welcome\Desktop\backup\csc.txt");
            //Console.WriteLine(readText);
            //String xDate = DateTime.Now.ToString("yyyy-MM-dd");
            //DatabaseConnection xDb = new DatabaseConnection();
            //Backup xBackUp = new Backup();
            //ConfigResponseModel configResponse = xDb.GetConfig();
            //xBackUp.BackUpDatabase(configResponse.BackUpPath);
            //BackUpResponseModel backupResponse = xDb.GetBackUpHistory(xDate);
            //if (backupResponse.BackUpPath == null)
            //{
            //    string xQry = "insert into backup (date,path) " +
            //        " values('" + xDate + "','" + configResponse.BackUpPath + "')";
            //    xDb.DataProcess(xQry);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Device.Location;


namespace ECare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<string> hospList = new List<string>();
            List<string> hospLists = new List<string>();
            List<string> listA = new List<string>();
            int listLen = 0;

            using (var reader = new StreamReader(@"C:\GitHub\ECare\ECare\db.csv"))
            {
                string tableName = "Hospitals";
                DataSet dataset = new DataSet();
                dataset.Tables.Add(tableName);
                dataset.Tables[tableName].Columns.Add("Number");
                dataset.Tables[tableName].Columns.Add("Name");
                dataset.Tables[tableName].Columns.Add("Select");
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if(values[1] == txtLocation.Text)
                    {
                        listA.Add(values[0]);
                    }
                    listLen = listA.Count;

                }

                
                


                for (int i = 0; i < listLen; i++)
                {

                    txtGps.AppendText(listA[i]+Environment.NewLine);

                    
                }
            }

            StringBuilder location1 = new StringBuilder();

            location1.Append("http://maps.google.ie/maps?q=");
            location1.Append(txtLocation.Text + " hospital");
            wbHosp.Navigate(location1.ToString());
            wbHosp.ScriptErrorsSuppressed = true;
        }

        private void txtGps_TextChanged(object sender, EventArgs e)
        {

        }

        private void wbHosp_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGps.Text = "";
            txtLocation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

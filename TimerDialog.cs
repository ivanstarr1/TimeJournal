using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Odbc;
using System.Data.OleDb;

namespace TimeJournal
{
    public partial class TimerDialog : Form
    {
        public TimerDialog()
        {
            InitializeComponent();
        }

        private void TimerDialog_Load(object sender, EventArgs e)
        {







        }

      

        private void button2_Click(object sender, EventArgs e)
        {

            // The connection string assumes that the Access
            // Northwind.mdb is located in the c:\Data folder.
            string connectionString =
                "Driver={Microsoft Access Driver (*.mdb, *.accdb)};"
                + "Dbq=C:\\Users\\IvanS\\source\\repos\\TimeJournal\\TimeJournal.mdb;";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT Id, Name from Projects;";

            // Specify the parameter value.
            //int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (OdbcConnection connection =
                new OdbcConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                OdbcCommand command = new OdbcCommand(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}",
                            reader[0], reader[1]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }

       
    }
}

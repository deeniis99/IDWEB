using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDWEB4
{
    class Class1
    {
        /* SqlConnection conect;
         public SqlConnection connect()
         {
             string connetionString;
             connetionString = @"Data Source=DESKTOP-6MRAHOK\SQLEXPRESS;Initial Catalog=IDWEB;User ID=sa;Password=qwerty78";
             conect = new SqlConnection(connetionString);
             conect.Open();
             MessageBox.Show("Connection Open  !");
             return conect;
         }*/
        /*public Class1()
        {
            this.conect = connect();
        }*/
        /* public void disconnect()
         {
             conect.Close();
         }*/

        public void InsertBD(int a, int b, int c, double x1, double x2)
        {
            string connetionString;
            connetionString = @"Data Source=DESKTOP-6MRAHOK\SQLEXPRESS;Initial Catalog=IDWEB;User ID=sa;Password=qwerty78";
            SqlConnection conect = new SqlConnection(connetionString);

            string query = "INSERT INTO Table_1 (a,b,c,x1,x2) VALUES('" + a + "','" + b + "','" + c + "','" + x1 + "','" + x2 + "')";
            SqlCommand command = new SqlCommand(query, conect);
            try
            {
                conect.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Records Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conect.Close();
            }


        }
        public double[] read(int a, int b, int c)
        {
            string connetionString;
            connetionString = @"Data Source=DESKTOP-6MRAHOK\SQLEXPRESS;Initial Catalog=IDWEB;User ID=sa;Password=qwerty78";
            SqlConnection conect = new SqlConnection(connetionString);

            string query = "SELECT x1,x2 FROM Table_1 WHERE a=" + a + " AND b=" + b + " AND c=" + c + "";
            //MessageBox.Show(query);
            SqlCommand command = new SqlCommand(query, conect);
            conect.Open();
            SqlDataReader dr = command.ExecuteReader();
            double x1=-99999;
            double x2 = -99999;
            if (dr.HasRows)
            { 
                while (dr.Read())
                {
                    x1 = dr.GetDouble(0);
                    x2 = dr.GetDouble(1);
                    MessageBox.Show("Resukts found on DB");
                }
               

            }
            dr.Close();
            conect.Close();
            double[] array = { x1, x2 };
            return array;
            
        }
    }
}

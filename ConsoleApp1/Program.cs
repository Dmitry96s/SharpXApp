using Microsoft.SqlServer.Server;
using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ConsoleApp1
{
  class Program
  {
    [SqlFunction(DataAccess = DataAccessKind.Read)]
    public static string Show(string user_id)
    {
      string course = "";
      string name = "";
      SqlDateTime expiring = SqlDateTime.MaxValue;
      using (SqlConnection connection = new SqlConnection("Server = tcp:testsharp.database.windows.net,1433; Initial Catalog = sharpDB; Persist Security Info = False; User ID =Dmitry; Password =13_A$uRe; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"))

      //using (SqlConnection connection = new SqlConnection("Server=tcp:sfedutest.database.windows.net,1433;Initial Catalog=TestDB;Persist Security Info=False;User ID=Dmitry;Password=13_A$uRe;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
      {
        connection.Open();
        SqlCommand sqlcmd = new SqlCommand(@"SELECT TOP(1) text FROM TodoItem", connection);
        //sqlcmd.Parameters.AddWithValue("@login", user_id);
        SqlDataReader reader = sqlcmd.ExecuteReader();
        using (reader)
        {
          //Console.WriteLine("Course\t\t\tName");
          while (reader.Read())
          {
            course = (string)reader.GetSqlString(0);
            //name = (string)reader.GetSqlString(1);
            // expiring = reader.GetSqlDateTime(2);
            //Console.WriteLine("{0}\t{1}\t{2}",course,name,expiring);
            Console.WriteLine(course);
          }
        }
      }
      return name;
    }
    static void Main(string[] args)
    {
      //string login = args[0];
      Show("");
      Console.ReadKey();
    }
  }
}


using System;
using System.Data.SqlClient;

namespace INS215L_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""\\Mac\Home\Downloads\INS215L_No.1_1093141_Camila De Los Santos\INS215L_No.1_1093141_Camila De Los Santos\Laboratorio_1\MyData.mdf""; Integrated Security = True");
            connection.Open();
            Console.WriteLine(connection.State);

            {
                Student Class = new Student()
                {
                    ID = 1093141,
                    Name = "Camila Esther",
                    LastName = "De Los Santos Arias"
                };
                Console.WriteLine("\nID: {0} \nNombres: {1}\nApellidos: {2}", Class.ID, Class.Name, Class.LastName);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}  
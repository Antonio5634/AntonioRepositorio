using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace teste1DB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "@ Data Sourcer=(TesteDB)\vl1.0;Attach0bfilename =C:\Users\antoniosmac\Source\Repos\AntonioRepositorio";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //SqlCommand comand = new SqlCommand("SELECT * FROM Produto", sqlConnection);
            //SqlDataReader reader = comand.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["Nome"]);
            //}
            Console.WriteLine("informe o nome");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o unidade");
            string nome = Console.ReadLine();
            Console.WriteLine("digite o valor do prduto");
            double valor = Convert.ToDouble(Console.ReadLine());
            
            string sqlUpdate = string.Format("UPDATE Produto SET (Nome,Unidade,Valor) VALUES ('{0}','{1}','{2}')");
            SqlCommand comand = new SqlCommand(sqlUpdate,sqlConnection);

            try
            {
              int  i = comand.ExecuteNonQuery();
                if(i>0)
                {
                   Console.WriteLine(  "deletado com sucesso");
                }
               
            }
            catch(SqlException e)
            {
               Console.WriteLine(e.ToString);
            }
            
            
            //if(i>0)
            //{
            //    Console.WriteLine("Produto atualizado com sucesso");
            //}
            //else
            //{
            //    Console.WriteLine("FODEU?!");
            //}


        }
    }
}

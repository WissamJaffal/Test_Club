using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_POO1_Grafico
{
    internal class Banco
    {

        public static SqlConnection Abrir()
        {
            string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Desktop\2024_POO1_Grafico\2024_POO1_Grafico\Banco_Poo1.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;

        }
    }
}

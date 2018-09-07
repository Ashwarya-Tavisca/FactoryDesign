using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class SqlDatabase : IRepository
    {
        public void Add(IProduct product, int Fare)
            {
                SqlConnection connectionobject = new SqlConnection();
                connectionobject.ConnectionString = "Data Source=.;Initial Catalog=ProductsDatabase;User ID=sa;Password=test123!@#";
                connectionobject.Open();
                string query = "insert into " + product.ProductType + " values(@name,@fare,@isbooked)";
                SqlCommand cmd = new SqlCommand(query, connectionobject);
                cmd.Parameters.Add(new SqlParameter("@name", product.ProductName));
                cmd.Parameters.Add(new SqlParameter("@fare", Fare));
                cmd.Parameters.Add(new SqlParameter("@isbooked", product.IsBooked));
                cmd.ExecuteNonQuery();
                connectionobject.Close();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace WinDisconArchDemo
{
    class ProductUtility : IProductRepo
    {
        SqlConnection con;
        SqlDataAdapter adap1;
        DataSet ds;

        public ProductUtility()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\Sqlexpress; Integrated Security = SSPI; Database = LPU_DB; TrustServerCertificate=true";

        }


        public bool AddData(Product Obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3BudgetProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3CostlyProduct()
        {
            throw new NotImplementedException();
        }

        public Product SearchByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAll()
        {
            List<Product> prodList = null;
            
            adap1 = new SqlDataAdapter("Select * from Products", (SqlConnection)con);
            adap1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            adap1.Fill(ds, "Prod");

            if (ds.Tables[0].Rows.Count > 0)
            {
                prodList = new List<Product>();

                foreach(DataRow drow in ds.Tables["Prod"].Rows)
                {
                    Product p1 = new Product()
                    {
                        ProdID = Int32.Parse(drow[0].ToString()),
                        ProdName = drow[1].ToString(),
                        CatName = drow[2].ToString(),
                        Price = int.Parse(drow[3].ToString()),
                        Desc = drow[4].ToString()
                    };
                    prodList.Add(p1);
                }
                
            }
            return prodList;
        }

        public List<Product> ShowAllProductCategory(int catID)
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceAsc()
        {
            throw new NotImplementedException();
        }

        public List<Product> SortProductByPriceDesc()
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(int id, Product Obj)
        {
            throw new NotImplementedException();
        }
    }
}

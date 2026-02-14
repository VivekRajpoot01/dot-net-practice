using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconArchDemo
{
    /// <summary>
    /// Entity Class Product
    /// </summary>
    
    public class Product
    {
        #region Fields
            int prodID;
            string prodName;
            int price;
            string desc;

        #endregion

        #region Properties
        // CLR Properties

        public int ProdID
        {
            get { return prodID; }
            set
            {
                if(value<=0 || value > 999)
                {
                    throw new IdNotInRangeException("Id value not in range [1,999]");
                }
                prodID = value;
            }
        }
        public string ProdName
        {
            get
            {
                return prodName;
            }
            set
            {
                prodName = value; 
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }

        public string CatName { get; set; }

        #endregion



    }
}

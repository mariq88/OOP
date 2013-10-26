using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class ProductNotExistsExeption : ApplicationException
    {
        public ProductNotExistsExeption(string msg) : base(msg)
        {
        }

        public ProductNotExistsExeption(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface ISearchable
    {
        //List<string> Search { get; set; }
        //bool SearchByAuthor(Book author);
        bool SearchByName(Product name);
       


    }
}

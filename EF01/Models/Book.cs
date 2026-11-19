using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    public class Book
    {

        public int Id {  get; set; }
        public string Title { get; set; }
        public int ISPN { get; set; }
        public decimal Price { get; set; }
        public int  NumOfPages { get; set; }
        public int Year { get; set; }
        public bool IsInStock { get; set; }



    }
}

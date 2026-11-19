using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    public  class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string EmailAddress { get; set; }
        public string biography { get; set; }
        public int DOF { get; set; }

    }
}

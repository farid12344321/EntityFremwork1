using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFremework_Homework1.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        public override string ToString()
        {
            return Id +" - "+Name +" - "+ Date;
        }

    }
}

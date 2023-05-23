using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_Motorcycle.Model
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Product { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            return $"{Id}\n{Login}\n{Product}\n{Price}";
        }
    }
}
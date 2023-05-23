using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_Motorcycle.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string TypeProduct { get; set; }
        public string ColourProduct { get; set; }
        public string EngineProduct { get; set; }
        public string TransmissionProduct { get; set; }
        public string DriveProduct { get; set; }
        public string QuantityProduct { get; set; }
        public string PriceProduct { get; set; }
        public override string ToString()
        {
            return $"{ProductId}\n\n{ProductName}\n\nТип:  {TypeProduct}\nЦвет:  {ColourProduct}\nДвигатель:  {EngineProduct}\nКоробка:  {TransmissionProduct}\nПривод:  {DriveProduct}\n\n{PriceProduct}\n\n{QuantityProduct}";
        }
    }
}

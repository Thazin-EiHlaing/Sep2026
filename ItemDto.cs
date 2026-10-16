using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sep2026.ElectronicShop
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string BrandName { get; set; } = "";
        public string ModelNo { get; set; } = "";
        public decimal PurPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
    }
}


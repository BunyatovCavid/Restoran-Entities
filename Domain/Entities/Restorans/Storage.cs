using Restoran_Entities.Entities.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Entities.Entities.Resotans
{
    internal class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(Seller))]
        public int SellerId { get; set; }
        public int numeral { get; set; }
    }
}

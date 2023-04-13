using Restoran_Entities.Entities.Adress;
using Restoran_Entities.Entities.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Entities.Entities.Resotans
{
    internal class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Number))]
        public int NumberId { get; set; }
        [ForeignKey(nameof(Street))]
        public int AdressId { get; set; }
        [ForeignKey(nameof(Category))]
        public List<Category> CategoryId { get; set; }
    }
}

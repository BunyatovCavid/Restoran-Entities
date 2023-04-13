using Restoran_Entities.Entities.Adress;
using Restoran_Entities.Entities.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Entities.Entities
{
    internal class Restoran
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }
        [ForeignKey(nameof(Number))]
        public int Restoran_Number { get; set; }
        [ForeignKey(nameof(Menu))]
        public int Restoran_Menu { get; set; }
        [ForeignKey(nameof(Street))]
        public int Restoran_Adress { get; set; }
    }
}

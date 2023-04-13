using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Entities.Entities.Adress
{
    internal class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Entities.Entities.Adress
{
    internal class Number
    {
        public int Id { get; set; }

        public int Special_number { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
    }
}

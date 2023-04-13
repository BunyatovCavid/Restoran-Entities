using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Entities.Entities.Categories
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

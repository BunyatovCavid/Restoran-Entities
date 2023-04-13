using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoran_Entities.Entities.Adress;
using Restoran_Entities.Entities.Categories;
using Restoran_Entities.Entities.Employees;

namespace Restoran_Entities.Entities.Resotans
{
    internal class Restoran_Back
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }

        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }

        [ForeignKey(nameof(Employee))]
        public List<Employee> Employes { get; set; }
        [ForeignKey(nameof(Furniture))]
        public List<Furniture> FurnitureID { get; set; }

        [ForeignKey(nameof(Menu))]
        public int MenuId { get; set; }

        [ForeignKey(nameof(Number))]
        public int NumberId { get; set; }

        [ForeignKey(nameof(Street))]
        public int AdressId { get; set; }
    }
}

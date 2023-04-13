using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Entities.Entities.Employees
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

    }
}

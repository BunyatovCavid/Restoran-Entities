using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restoran_Entities.Entities;
using Restoran_Entities.Entities.Adress;
using Restoran_Entities.Entities.Categories;
using Restoran_Entities.Entities.Employees;
using Restoran_Entities.Entities.Resotans;

namespace Restoran_Entities.Domain
{
    internal class PlaceDbContex : DbContext
    {
        #region DbSet
        public DbSet<Restoran> Restorans { get; set; }
        #region Restorans
        public DbSet<Restoran_Back> Restoran_Backs { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        #endregion
        #region Menu
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Category> Categories { get; set; }
        #endregion
        #region Employee
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        #endregion
        #region Adress
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Street> Streets { get; set; }
        #endregion
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WIN-PFGV5N8DK24;Database=Rest;Trusted_Connection=True;");
        }

    }
}

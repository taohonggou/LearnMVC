using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LearnMVC.Models;

namespace LearnMVC.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// 重写了映射连接字符串的方法  base中的字符串就是新的连接字符串  
        /// </summary>
        public SalesERPDAL()
            : base("conStr")
        {

        }
    }


}
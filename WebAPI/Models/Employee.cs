using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Employee
    {
        public Employee() { }
        public Employee(int id, string name, int umur, string alamat)
        {
            Id = id;
            Name = name;
            Umur = umur;
            Alamat = alamat;
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Umur { get; set; }
        public string Alamat { get; set; }
        
        [ForeignKey("department")]
        public int DepartementID { get; set; }
        public Department department { get; set; }
        
        //public virtual Department Departments { get; set; }
    }
}
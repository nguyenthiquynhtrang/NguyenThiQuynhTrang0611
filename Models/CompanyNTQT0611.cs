using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NguyenThiQuynhTrang0611.Models;

    public class CompanyNTQT0611
    {
        [Key]
         public string? CompanyID  { get; set; }
         public string? CompanyName { get; set; }     
    }
using NguyenThiQuynhTrang0611.Models;
using Microsoft.EntityFrameworkCore;
namespace NguyenThiQuynhTrang0611.Data

{
    public class NTQTDb : DbContext
    {
          public NTQTDb (DbContextOptions<NTQTDb> options) : base(options)
          {

          }
          public DbSet<NguyenThiQuynhTrang0611.Models.CompanyNTQT0611> CompanyNTQT0611s {get; set;}
    }
    }
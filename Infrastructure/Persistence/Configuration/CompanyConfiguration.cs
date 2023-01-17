using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configuration;
public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasData(
            new Company
            {
                Id = new Guid("c3001bfb-4754-4336-8815-687d96bb1958"),
                Name = "IT_Solutions Ltd",
                Address = "583 Wall Dr. Gwynn Oak, MD 21200",
                Country = "USA"
            },
             new Company
             {
                 Id = new Guid("e1fde970-910e-45b5-a835-8a7208eff896"),
                 Name = "Admin_Solutions Ltd",
                 Address = "325 Forest Avenue, BF 359",
                 Country = "USA"
             }
            );
    }
}

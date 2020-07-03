using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWorkApplication.DAL.Configurations
{
    public class DishConfiguration: BaseEntityConfiguration<Dish>
    {
        protected override void ConfigureForeignKeys(EntityTypeBuilder<Dish> builder)
        {
            builder.HasOne(b => b.Cafe).WithMany(b => b.Dishes).HasForeignKey(b => b.Cafe);
        }
    }
}

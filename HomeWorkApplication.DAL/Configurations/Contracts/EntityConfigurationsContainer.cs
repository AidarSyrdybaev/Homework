using HomeWorkApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Configurations.Contracts
{
    public interface EntityConfigurationsContainer
    {
        IEntityConfiguration<User> UserConfig { get; }
        IEntityConfiguration<Dish> DishConfig { get; }
        IEntityConfiguration<Cafe> CafeConfig { get; }
        IEntityConfiguration<Bucket> OrderConfig { get; }
    }
}

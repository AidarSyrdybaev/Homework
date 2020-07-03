using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWorkApplication.DAL.Configurations.Contracts
{
    public interface IEntityConfiguration<T> where T: class, Entity
    {
        Action<EntityTypeBuilder<T>> ProvideConfigurationAction();
    }
}

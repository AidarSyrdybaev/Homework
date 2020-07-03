using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Configurations.Contracts;
using HomeWorkApplication.DAL.Entities;

namespace HomeWorkApplication.DAL.Configurations
{
    public class BaseEntityConfiguration<T>: IEntityConfiguration<T> where T: class, Entity
    {
        public Action<EntityTypeBuilder<T>> ProvideConfigurationAction()
        {
            return ConfigureEntity;
        }

        private void ConfigureEntity(EntityTypeBuilder<T> builder)
        {
            ConfigureProperties(builder);
            ConfigurePrimaryKeys(builder);
            ConfigureForeignKeys(builder);
        }

        protected virtual void ConfigureProperties(EntityTypeBuilder<T> builder) { }

        protected virtual void ConfigurePrimaryKeys(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
        }

        protected virtual void ConfigureForeignKeys(EntityTypeBuilder<T> builder) { }


    }
}

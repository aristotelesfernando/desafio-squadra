using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityConfiguration
{
    public class Gerenciamento_LeadConfiguration : IEntityTypeConfiguration<Gerenciamento_Lead>
    {
        public void Configure(EntityTypeBuilder<Gerenciamento_Lead> builder)
        {
            builder.Property(b => b.Contact_First_Name).HasMaxLength(80);
            builder.Property(b => b.Contact_Full_Name).HasMaxLength(200);
            builder.Property(b => b.Contact_Email).HasMaxLength(255);
            builder.Property(b => b.Contact_Phone_Number).HasMaxLength(20);
            builder.Property(b => b.Suburb).HasMaxLength(50);
            builder.Property(b => b.Category).HasMaxLength(50);
            builder.Property(b => b.Description).HasMaxLength(255);
            builder.Property(b => b.Price).HasColumnType("decimal(10,2)");
            builder.Property(b => b.Accepted).HasDefaultValue(false);

            builder.HasData(
                new Gerenciamento_Lead
                {
                    Contact_First_Name = "João",
                    Contact_Full_Name = "João da Silva",
                    Contact_Phone_Number = "55-21-988776655",
                    Contact_Email = "joao@hotmail.com",
                    Date_Created = DateTime.UtcNow,
                    Suburb = "Não sei",
                    Category = "Seriço doméstico",
                    Description = "Descrição xxxxxxxxxxxxxxxxxx",
                    Price = 20,
                    Accepted = 'A'
                },
                new Gerenciamento_Lead
                {
                    Contact_First_Name = "Carlos",
                    Contact_Full_Name = "Carlos Barbosa",
                    Contact_Phone_Number = "55-98-987660011",
                    Contact_Email = "cbarbosa@icloud.com",
                    Date_Created = DateTime.UtcNow,
                    Suburb = "Não sei",
                    Category = "Pintura",
                    Description = "Descrição xxxxxxxxxxxxxxxxxx",
                    Price = 100,
                    Accepted = 'A'
                },
                new Gerenciamento_Lead
                {
                    Contact_First_Name = "Ana Maria",
                    Contact_Full_Name = "Ana Maria Oliveira",
                    Contact_Phone_Number = "55-91-987785544",
                    Contact_Email = "anaoliveira@gmail.com",
                    Date_Created = DateTime.UtcNow,
                    Suburb = "Não sei",
                    Category = "Diarista",
                    Description = "Descrição xxxxxxxxxxxxxxxxxx",
                    Price = 50,
                    Accepted = 'A'
                }
            );

        }
    }
}

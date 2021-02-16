//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EscuelaSystemModels.Config
//{
//    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
//    {

//        protected void OnModelCreating(ModelBuilder builder)
//        {
//            builder.Entity<Materia>()
//                .HasOne(c => c.Alumno)
//                .WithMany(c => c.Materias)
//                .HasForeignKey(c => c.IdEstudiante)
//                .OnDelete (DeleteBehavior.Cascade);
//        }
//        public void Configure(EntityTypeBuilder<Materia> builder)
//        {
//            builder.HasKey(c => c.Id);

//            builder.Property(c => c.Codigo)
//                .IsRequired()
//                ;

//            builder.Property(c => c.Descripcion)
//                .IsRequired();

//            builder.Property(c => c.Habilitada)
//                .IsRequired();


//        }

//    }
//}

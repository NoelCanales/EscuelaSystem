//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EscuelaSystemModels.Config
//{
//    class AlumnoConfiguration : IEntityTypeConfiguration<Alumno>
//    {
//        protected void OnModelCreating(ModelBuilder builder)
//        {
//            builder.Entity<Alumno>()
//                .HasMany(c => c.Materias)
//                .WithOne(c => c.Alumno)
//                .HasForeignKey(c => c.IdEstudiante);
//        }
//        public void Configure(EntityTypeBuilder<Alumno> builder)
//        {
//            builder.HasKey(c => c.IdEstudiante);

//            builder.Property(c => c.Nombre)
//                .IsRequired()
//                ;

//            builder.Property(c => c.Apellido)
//                .IsRequired();

//            builder.Property(c => c.Carnet)
//                .IsRequired();
//            builder.Property(c => c.Materias)
//                .IsRequired();
//        }
//    }
//}

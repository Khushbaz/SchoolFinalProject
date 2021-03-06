// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolFinalProject.Data;

namespace SchoolFinalProject.Migrations
{
    [DbContext(typeof(SchoolFinalProjectContext))]
    partial class SchoolFinalProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolFinalProject.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("School_Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("SchoolFinalProject.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Student_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TutorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TutorID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SchoolFinalProject.Models.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tutor_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tutor_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tutor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tutor");
                });

            modelBuilder.Entity("SchoolFinalProject.Models.Student", b =>
                {
                    b.HasOne("SchoolFinalProject.Models.Tutor", "Tutor_ID")
                        .WithMany()
                        .HasForeignKey("TutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

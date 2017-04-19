using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RentalApplicationAPI.Data;

namespace RentalApplicationAPI.Migrations
{
    [DbContext(typeof(PropertyContext))]
    [Migration("20170411225749_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("RentalApplicationAPI.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FName1");

                    b.Property<string>("FName2");

                    b.Property<string>("LName1");

                    b.Property<string>("LName2");

                    b.Property<int>("PropertyID");

                    b.Property<string>("type");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("RentalApplicationAPI.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddtlComments");

                    b.Property<string>("City");

                    b.Property<string>("LeaseDuration");

                    b.Property<DateTime>("ListDate");

                    b.Property<int>("NumBaths");

                    b.Property<int>("NumbBeds");

                    b.Property<decimal>("RentAmt");

                    b.Property<int>("SqaureFootage");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("RentalApplicationAPI.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddtlComments");

                    b.Property<string>("City");

                    b.Property<DateTime>("ListDate");

                    b.Property<int>("NumBaths");

                    b.Property<int>("NumbBeds");

                    b.Property<decimal>("Price");

                    b.Property<int>("SqaureFootage");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });
        }
    }
}

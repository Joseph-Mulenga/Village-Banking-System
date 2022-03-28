﻿// <auto-generated />
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VILLAGEBANKING.Migrations.LoanEligibilityDB
{
    [DbContext(typeof(LoanEligibilityDBContext))]
    [Migration("20220328072151_LoanEligibility")]
    partial class LoanEligibility
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Models.LoanEligibilityModel", b =>
                {
                    b.Property<int>("LoanEligibleAmountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanEligibleAmountId"), 1L, 1);

                    b.Property<int>("AmountContribution")
                        .HasColumnType("int");

                    b.Property<int>("EligibleLoanAmount")
                        .HasColumnType("int");

                    b.HasKey("LoanEligibleAmountId");

                    b.ToTable("Group");
                });
#pragma warning restore 612, 618
        }
    }
}

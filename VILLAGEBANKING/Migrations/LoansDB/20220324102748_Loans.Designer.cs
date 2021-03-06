// <auto-generated />
using VILLAGEBANKING.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VILLAGEBANKING.Migrations.LoansDB
{
    [DbContext(typeof(LoansDBContext))]
    [Migration("20220324102748_Loans")]
    partial class Loans
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VILLAGEBANKING.Models.AccountsModel", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BankBranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AccountId");

                    b.ToTable("AccountsModel");
                });

            modelBuilder.Entity("VILLAGEBANKING.Models.LoansModel", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanId"), 1L, 1);

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoanBalance")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoanInstallmentEndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoanInstallmentStartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoanInterestRate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoanPayementPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoanPrincipal")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LoanId");

                    b.HasIndex("AccountId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("VILLAGEBANKING.Models.LoansModel", b =>
                {
                    b.HasOne("VILLAGEBANKING.Models.AccountsModel", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using VILLAGEBANKING.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VILLAGEBANKING.Migrations.GroupMembersDB
{
    [DbContext(typeof(GroupMembersDBContext))]
    partial class GroupMembersDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VILLAGEBANKING.Models.GroupMembersModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("GroupMemberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupMembershipStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("GroupMemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("VILLAGEBANKING.Models.GroupModel", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<int>("FrequencyOfContributions")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LoanEligibleAmountId")
                        .HasColumnType("int");

                    b.Property<double>("LoanRate")
                        .HasColumnType("float");

                    b.Property<double>("MinimumContributionAmount")
                        .HasColumnType("float");

                    b.Property<double>("PenaltyFee")
                        .HasColumnType("float");

                    b.Property<double>("ProvisionalInterest")
                        .HasColumnType("float");

                    b.HasKey("GroupId");

                    b.HasIndex("LoanEligibleAmountId");

                    b.ToTable("GroupModel");
                });

            modelBuilder.Entity("VILLAGEBANKING.Models.LoanEligibilityModel", b =>
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

                    b.ToTable("LoanEligibilityModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("VILLAGEBANKING.Models.GroupMembersModel", b =>
                {
                    b.HasOne("VILLAGEBANKING.Models.GroupModel", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Member")
                        .WithMany()
                        .HasForeignKey("GroupMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("VILLAGEBANKING.Models.GroupModel", b =>
                {
                    b.HasOne("VILLAGEBANKING.Models.LoanEligibilityModel", "LoanEligibility")
                        .WithMany()
                        .HasForeignKey("LoanEligibleAmountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoanEligibility");
                });
#pragma warning restore 612, 618
        }
    }
}

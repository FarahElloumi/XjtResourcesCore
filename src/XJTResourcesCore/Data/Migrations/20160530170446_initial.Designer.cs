using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using XJTResourcesCore.Data;

namespace XJTResourcesCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160530170446_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OpenIddict.Models.Application", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("DisplayName");

                    b.Property<string>("LogoutRedirectUri");

                    b.Property<string>("RedirectUri");

                    b.Property<string>("Secret");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Announcement", b =>
                {
                    b.Property<int>("AnnouncementId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("CssStyles");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PostedBy");

                    b.Property<string>("Title");

                    b.HasKey("AnnouncementId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Base");

                    b.Property<string>("Company");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DOH");

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsPilot");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Position");

                    b.Property<bool>("PushNotifications");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.AspNetUserEx", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("SecurityAnswer");

                    b.Property<string>("SecurityAnswerSalt");

                    b.Property<string>("SecurityQuestion");

                    b.HasKey("UserId");

                    b.ToTable("AspNetUserExts");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PostedBy");

                    b.Property<string>("SubCategory")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EntertainmentComment");

                    b.Property<string>("FoodComment");

                    b.Property<string>("HotelComment");

                    b.Property<int>("HotelId");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PostedBy");

                    b.Property<int>("Rating");

                    b.HasKey("CommentId");

                    b.HasIndex("HotelId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Correction", b =>
                {
                    b.Property<int>("CorrectionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Changes");

                    b.Property<string>("CorrectiveAction");

                    b.Property<int>("HotelId");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsUpdated");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PostedBy");

                    b.Property<string>("UserId");

                    b.HasKey("CorrectionId");

                    b.HasIndex("HotelId");

                    b.ToTable("Corrections");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("DocTitle");

                    b.Property<string>("FileName");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Path");

                    b.Property<string>("PostedBy");

                    b.Property<long>("Size");

                    b.HasKey("DocumentId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("EmailAddress");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<string>("PostedBy");

                    b.HasKey("EmailId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Faq", b =>
                {
                    b.Property<int>("FaqId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<int>("CategoryId");

                    b.Property<string>("ContractSection");

                    b.Property<string>("Html");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsHTML");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PostedBy");

                    b.Property<string>("Question");

                    b.HasKey("FaqId");

                    b.HasIndex("CategoryId");

                    b.ToTable("FAQs");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<bool>("Amenities123");

                    b.Property<bool>("Amenities234");

                    b.Property<bool>("AmenitiesA");

                    b.Property<bool>("AmenitiesBC");

                    b.Property<bool>("AmenitiesBG");

                    b.Property<bool>("AmenitiesCR");

                    b.Property<bool>("AmenitiesDR");

                    b.Property<bool>("AmenitiesECI");

                    b.Property<bool>("AmenitiesFD");

                    b.Property<bool>("AmenitiesG");

                    b.Property<bool>("AmenitiesGO");

                    b.Property<bool>("AmenitiesGS");

                    b.Property<bool>("AmenitiesID");

                    b.Property<bool>("AmenitiesLF");

                    b.Property<bool>("AmenitiesMW");

                    b.Property<bool>("AmenitiesNS");

                    b.Property<bool>("AmenitiesOP");

                    b.Property<bool>("AmenitiesRF");

                    b.Property<bool>("AmenitiesRP");

                    b.Property<bool>("AmenitiesSF");

                    b.Property<bool>("AmenitiesTVF");

                    b.Property<bool>("AmenitiesTVL");

                    b.Property<string>("City");

                    b.Property<string>("CityXXX");

                    b.Property<string>("Discounts");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("InternetBCF");

                    b.Property<bool>("InternetHWF");

                    b.Property<string>("InternetNotes");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<string>("OvernightLongShort");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostedBy");

                    b.Property<string>("State");

                    b.Property<string>("Transportation");

                    b.Property<string>("ZipCode");

                    b.Property<bool>("internetWF");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Jumpseat", b =>
                {
                    b.Property<int>("JumpseatId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Airline");

                    b.Property<string>("Details");

                    b.Property<string>("Html");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Phone");

                    b.Property<string>("PostedBy");

                    b.Property<string>("Website");

                    b.HasKey("JumpseatId");

                    b.ToTable("Jumpseats");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LinkType");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PostedBy");

                    b.Property<string>("Url");

                    b.Property<string>("UrlTitle");

                    b.HasKey("LinkId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Version", b =>
                {
                    b.Property<int>("VersionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AndroidDate");

                    b.Property<double>("AndroidNum");

                    b.Property<DateTime>("Inserted");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("PostedBy");

                    b.Property<DateTime>("WinUWPDate");

                    b.Property<double>("WinUWPNum");

                    b.Property<DateTime>("iOSDate");

                    b.Property<double>("iOSNum");

                    b.HasKey("VersionId");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("XJTResourcesCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Comment", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Correction", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Document", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Email", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XJTResourcesCore.Models.Faq", b =>
                {
                    b.HasOne("XJTResourcesCore.Models.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

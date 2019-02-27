using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Resort.Domain.Entities
{
    public partial class ResortSiteDbContext : DbContext
    {
        public ResortSiteDbContext()
        {
        }

        public ResortSiteDbContext(DbContextOptions<ResortSiteDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accommodation> Accommodation { get; set; }
        public virtual DbSet<AccommodationAmenity> AccommodationAmenity { get; set; }
        public virtual DbSet<AccommodationHouseRule> AccommodationHouseRule { get; set; }
        public virtual DbSet<AccommodationImage> AccommodationImage { get; set; }
        public virtual DbSet<AccommodationLocation> AccommodationLocation { get; set; }
        public virtual DbSet<AccommodationRating> AccommodationRating { get; set; }
        public virtual DbSet<AccommodationReservation> AccommodationReservation { get; set; }
        public virtual DbSet<AccommodationType> AccommodationType { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityLocation> ActivityLocation { get; set; }
        public virtual DbSet<ActivityRating> ActivityRating { get; set; }
        public virtual DbSet<ActivityReservation> ActivityReservation { get; set; }
        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<Amenity> Amenity { get; set; }
        public virtual DbSet<CardType> CardType { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ExtraInformation> ExtraInformation { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodType> FoodType { get; set; }
        public virtual DbSet<HouseRule> HouseRule { get; set; }
        public virtual DbSet<HouseRuleDescription> HouseRuleDescription { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LoginHistory> LoginHistory { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumber { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<RestaurantLocation> RestaurantLocation { get; set; }
        public virtual DbSet<RestaurantMenu> RestaurantMenu { get; set; }
        public virtual DbSet<RestaurantRating> RestaurantRating { get; set; }
        public virtual DbSet<RestaurantReservation> RestaurantReservation { get; set; }
        public virtual DbSet<RestaurantType> RestaurantType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SleepingArrangement> SleepingArrangement { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=157.230.42.3;Database=ResortSite;Username=resortsite;Password=P@$$w0rdE");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Accommodation>(entity =>
            {
                entity.ToTable("Accommodation", "accommodation");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('accommodation.\"Accommodation_ID_seq\"'::regclass)");

                entity.Property(e => e.AccommodationTypeId).HasColumnName("AccommodationTypeID");

                entity.Property(e => e.CancellationPolicy).HasColumnType("character varying");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CoverImage).HasColumnType("character varying");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MainImage).HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.PricePerNight).HasColumnType("numeric");

                entity.HasOne(d => d.AccommodationType)
                    .WithMany(p => p.Accommodation)
                    .HasForeignKey(d => d.AccommodationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Accommodation_AccommodationTypeID_fkey");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Accommodation)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Accommodation_CategoryID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Accommodation)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Accommodation_LanguageID_fkey");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Accommodation)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("Accommodation_LocationID_fkey");
            });

            modelBuilder.Entity<AccommodationAmenity>(entity =>
            {
                entity.HasKey(e => e.AccommodationId)
                    .HasName("AccommodationAmenity_pkey");

                entity.ToTable("AccommodationAmenity", "accommodation");

                entity.Property(e => e.AccommodationId)
                    .HasColumnName("AccommodationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmenityId).HasColumnName("AmenityID");

                entity.HasOne(d => d.Accommodation)
                    .WithOne(p => p.AccommodationAmenity)
                    .HasForeignKey<AccommodationAmenity>(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AccommodationAmenity_AccommodationID_fkey");

                entity.HasOne(d => d.Amenity)
                    .WithMany(p => p.AccommodationAmenity)
                    .HasForeignKey(d => d.AmenityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AccommodationAmenity_AmenityID_fkey");
            });

            modelBuilder.Entity<AccommodationHouseRule>(entity =>
            {
                entity.HasKey(e => e.AccommodationId)
                    .HasName("AccommodationHouseRule_pkey");

                entity.ToTable("AccommodationHouseRule", "accommodation");

                entity.Property(e => e.AccommodationId)
                    .HasColumnName("AccommodationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HouseRuleId).HasColumnName("HouseRuleID");

                entity.HasOne(d => d.Accommodation)
                    .WithOne(p => p.AccommodationHouseRule)
                    .HasForeignKey<AccommodationHouseRule>(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AccommodationHouseRule_AccommodationID_fkey");

                entity.HasOne(d => d.HouseRule)
                    .WithMany(p => p.AccommodationHouseRule)
                    .HasForeignKey(d => d.HouseRuleId)
                    .HasConstraintName("AccommodationHouseRule_HouseRuleID_fkey");
            });

            modelBuilder.Entity<AccommodationImage>(entity =>
            {
                entity.HasKey(e => e.AccommodationId)
                    .HasName("AccommodationImage_pkey");

                entity.ToTable("AccommodationImage", "accommodation");

                entity.Property(e => e.AccommodationId)
                    .HasColumnName("AccommodationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Image).HasColumnType("character varying");

                entity.HasOne(d => d.Accommodation)
                    .WithOne(p => p.AccommodationImage)
                    .HasForeignKey<AccommodationImage>(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AccommodationImage_AccommodationID_fkey");
            });

            modelBuilder.Entity<AccommodationLocation>(entity =>
            {
                entity.ToTable("Accommodation_Location", "accommodation");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('accommodation.\"Location_ID_seq\"'::regclass)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Distance).HasColumnType("character varying");

                entity.Property(e => e.DistanceDescription).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AccommodationLocation)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Location_LanguageID_fkey");
            });

            modelBuilder.Entity<AccommodationRating>(entity =>
            {
                entity.HasKey(e => e.AccommodationId)
                    .HasName("Rating_pkey");

                entity.ToTable("Accommodation_Rating", "accommodation");

                entity.Property(e => e.AccommodationId)
                    .HasColumnName("AccommodationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("character varying");

                entity.Property(e => e.Modified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Accommodation)
                    .WithOne(p => p.AccommodationRating)
                    .HasForeignKey<AccommodationRating>(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rating_AccommodationID_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccommodationRating)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Rating_UserID_fkey");
            });

            modelBuilder.Entity<AccommodationReservation>(entity =>
            {
                entity.ToTable("Accommodation_Reservation", "accommodation");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('accommodation.\"Reservation_ID_seq\"'::regclass)");

                entity.Property(e => e.AccommodationId).HasColumnName("AccommodationID");

                entity.Property(e => e.AmountPaid).HasColumnType("numeric");

                entity.Property(e => e.CancellationDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.CheckIn).HasColumnType("date");

                entity.Property(e => e.CheckOut).HasColumnType("date");

                entity.Property(e => e.Created).HasColumnType("timestamp with time zone");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Modified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.RefundPaid).HasColumnType("numeric");

                entity.Property(e => e.Status).HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Accommodation)
                    .WithMany(p => p.AccommodationReservation)
                    .HasForeignKey(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_AccommodationID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AccommodationReservation)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Reservation_LanguageID_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccommodationReservation)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_UserID_fkey");
            });

            modelBuilder.Entity<AccommodationType>(entity =>
            {
                entity.ToTable("AccommodationType", "accommodation");

                entity.HasIndex(e => e.Type)
                    .HasName("AccommodationType_Type_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('accommodation.\"AccommodationType_ID_seq\"'::regclass)");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AccommodationType)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("AccommodationType_LanguageID_fkey");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity", "activity");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('activity.\"Activity_ID_seq\"'::regclass)");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.CancellationPolicy).HasColumnType("character varying");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Include).HasColumnType("character varying");

                entity.Property(e => e.LanguageAvailable).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.OtherDescription).HasColumnType("character varying");

                entity.Property(e => e.PricePerPerson).HasColumnType("character varying");

                entity.Property(e => e.Provide).HasColumnType("character varying");

                entity.Property(e => e.ToBring).HasColumnType("character varying");

                entity.Property(e => e.ToDo).HasColumnType("character varying");

                entity.Property(e => e.WhoCanCome).HasColumnType("character varying");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Activity_ActivityTypeID_fkey");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Activity_CategoryID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Activity_LanguageID_fkey");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("Activity_LocationID_fkey");
            });

            modelBuilder.Entity<ActivityLocation>(entity =>
            {
                entity.ToTable("Activity_Location", "activity");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('activity.\"Location_ID_seq\"'::regclass)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Distance).HasColumnType("character varying");

                entity.Property(e => e.DistanceDescription).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ActivityLocation)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Location_LanguageID_fkey");
            });

            modelBuilder.Entity<ActivityRating>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("Rating_pkey");

                entity.ToTable("Activity_Rating", "activity");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ActivityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("character varying");

                entity.Property(e => e.Date).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Modified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Activity)
                    .WithOne(p => p.ActivityRating)
                    .HasForeignKey<ActivityRating>(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rating_ActivityID_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityRating)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Rating_UserID_fkey");
            });

            modelBuilder.Entity<ActivityReservation>(entity =>
            {
                entity.ToTable("Activity_Reservation", "activity");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('activity.\"Reservation_ID_seq\"'::regclass)");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.AmountPaid).HasColumnType("numeric");

                entity.Property(e => e.CancellationDate).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Created).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Date).HasColumnType("timestamp with time zone");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Modified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.RefundPaid).HasColumnType("numeric");

                entity.Property(e => e.Status).HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityReservation)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_ActivityID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ActivityReservation)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Reservation_LanguageID_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityReservation)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_UserID_fkey");
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.ToTable("ActivityType", "activity");

                entity.HasIndex(e => e.Name)
                    .HasName("ActivityType_Name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('activity.\"ActivityType_ID_seq\"'::regclass)");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ActivityType)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("ActivityType_LanguageID_fkey");
            });

            modelBuilder.Entity<Amenity>(entity =>
            {
                entity.ToTable("Amenity", "accommodation");

                entity.HasIndex(e => e.Name)
                    .HasName("Amenity_Name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('accommodation.\"Amenity_ID_seq\"'::regclass)");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Image).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Amenity)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Amenity_LanguageID_fkey");
            });

            modelBuilder.Entity<CardType>(entity =>
            {
                entity.ToTable("CardType", "user");

                entity.HasIndex(e => e.Type)
                    .HasName("CardType_Type_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('\"user\".\"CardType_ID_seq\"'::regclass)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "category");

                entity.HasIndex(e => e.Name)
                    .HasName("Category_Name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('category.\"Category_ID_seq\"'::regclass)");

                entity.Property(e => e.Created).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Modify).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Category_LanguageID_fkey");
            });

            modelBuilder.Entity<ExtraInformation>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("ExtraInformation_pkey");

                entity.ToTable("ExtraInformation", "user");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmergencyContact).HasColumnType("character varying");

                entity.Property(e => e.Occupation).HasColumnType("character varying");

                entity.Property(e => e.School).HasColumnType("character varying");

                entity.Property(e => e.TimeZone).HasColumnType("character varying");

                entity.Property(e => e.Work).HasColumnType("character varying");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.ExtraInformation)
                    .HasForeignKey<ExtraInformation>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ExtraInformation_UserID_fkey");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.FoodTypeId)
                    .HasName("Food_pkey");

                entity.ToTable("Food", "restaurant");

                entity.Property(e => e.FoodTypeId)
                    .HasColumnName("FoodTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ingredients)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Price).HasColumnType("numeric");

                entity.HasOne(d => d.FoodType)
                    .WithOne(p => p.Food)
                    .HasForeignKey<Food>(d => d.FoodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Food_FoodTypeID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Food)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Food_LanguageID_fkey");
            });

            modelBuilder.Entity<FoodType>(entity =>
            {
                entity.ToTable("FoodType", "restaurant");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('restaurant.\"FoodType_ID_seq\"'::regclass)");

                entity.Property(e => e.FoodType1)
                    .HasColumnName("FoodType")
                    .HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FoodType)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FoodType_LanguageID_fkey");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.FoodType)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FoodType_MenuID_fkey");
            });

            modelBuilder.Entity<HouseRule>(entity =>
            {
                entity.ToTable("HouseRule", "accommodation");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('accommodation.\"HouseRule_ID_seq\"'::regclass)");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name).HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.HouseRule)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("HouseRule_LanguageID_fkey");
            });

            modelBuilder.Entity<HouseRuleDescription>(entity =>
            {
                entity.HasKey(e => e.HouseRuleId)
                    .HasName("HouseRuleDescription_pkey");

                entity.ToTable("HouseRuleDescription", "accommodation");

                entity.Property(e => e.HouseRuleId)
                    .HasColumnName("HouseRuleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HouseRuleDescription1)
                    .HasColumnName("HouseRuleDescription")
                    .HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.HasOne(d => d.HouseRule)
                    .WithOne(p => p.HouseRuleDescription)
                    .HasForeignKey<HouseRuleDescription>(d => d.HouseRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HouseRuleDescription_HouseRuleID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.HouseRuleDescription)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("HouseRuleDescription_LanguageID_fkey");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("Language_Code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("Language_Language_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<LoginHistory>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("LoginHistory_pkey");

                entity.ToTable("LoginHistory", "user");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Browser).HasColumnType("character varying");

                entity.Property(e => e.Date).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Device).HasColumnType("character varying");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.RecentActivity).HasColumnType("character varying");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.LoginHistory)
                    .HasForeignKey<LoginHistory>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LoginHistory_UserID_fkey");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu", "restaurant");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('restaurant.\"Menu_ID_seq\"'::regclass)");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MenuType).HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Menu_LanguageID_fkey");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PaymentMethod_pkey");

                entity.ToTable("PaymentMethod", "user");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardHolderName)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.CardTypeId).HasColumnName("CardTypeID");

                entity.Property(e => e.IssuingBank)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.CardType)
                    .WithMany(p => p.PaymentMethod)
                    .HasForeignKey(d => d.CardTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PaymentMethod_CardTypeID_fkey");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.PaymentMethod)
                    .HasForeignKey<PaymentMethod>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PaymentMethod_UserID_fkey");
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PhoneNumber_pkey");

                entity.ToTable("PhoneNumber", "user");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.PhoneNumber)
                    .HasForeignKey<PhoneNumber>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PhoneNumber_UserID_fkey");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant", "restaurant");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('restaurant.\"Restaurant_ID_seq\"'::regclass)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreditCard).HasColumnType("character varying");

                entity.Property(e => e.DiningOption).HasColumnType("character varying");

                entity.Property(e => e.Drink).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MealService).HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Parking).HasColumnType("character varying");

                entity.Property(e => e.Price).HasColumnType("character varying");

                entity.Property(e => e.PriceRange).HasColumnType("numeric");

                entity.Property(e => e.ReservationStatus).HasColumnType("character varying");

                entity.Property(e => e.RestaurantTypeId).HasColumnName("RestaurantTypeID");

                entity.Property(e => e.Restroom).HasColumnType("character varying");

                entity.Property(e => e.Wifi).HasColumnType("character varying");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Restaurant_CategoryID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Restaurant_LanguageID_fkey");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("Restaurant_LocationID_fkey");

                entity.HasOne(d => d.RestaurantType)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.RestaurantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Restaurant_RestaurantTypeID_fkey");
            });

            modelBuilder.Entity<RestaurantLocation>(entity =>
            {
                entity.ToTable("Restaurant_Location", "restaurant");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('restaurant.\"Location_ID_seq\"'::regclass)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.Distance).HasColumnType("character varying");

                entity.Property(e => e.DistanceDescription).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<RestaurantMenu>(entity =>
            {
                entity.HasKey(e => e.RestaurantId)
                    .HasName("RestaurantMenu_pkey");

                entity.ToTable("RestaurantMenu", "restaurant");

                entity.Property(e => e.RestaurantId)
                    .HasColumnName("RestaurantID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.RestaurantMenu)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RestaurantMenu_MenuID_fkey");

                entity.HasOne(d => d.Restaurant)
                    .WithOne(p => p.RestaurantMenu)
                    .HasForeignKey<RestaurantMenu>(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RestaurantMenu_RestaurantID_fkey");
            });

            modelBuilder.Entity<RestaurantRating>(entity =>
            {
                entity.HasKey(e => e.RestaurantId)
                    .HasName("Rating_pkey");

                entity.ToTable("Restaurant_Rating", "restaurant");

                entity.Property(e => e.RestaurantId)
                    .HasColumnName("RestaurantID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("character varying");

                entity.Property(e => e.Date).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Modified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Restaurant)
                    .WithOne(p => p.RestaurantRating)
                    .HasForeignKey<RestaurantRating>(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rating_RestaurantID_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RestaurantRating)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Rating_UserID_fkey");
            });

            modelBuilder.Entity<RestaurantReservation>(entity =>
            {
                entity.ToTable("Restaurant_Reservation", "restaurant");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('restaurant.\"Reservation_ID_seq\"'::regclass)");

                entity.Property(e => e.Created).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Date).HasColumnType("timestamp with time zone");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Modified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.Status).HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.RestaurantReservation)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("Reservation_LanguageID_fkey");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantReservation)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_RestaurantID_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RestaurantReservation)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reservation_UserID_fkey");
            });

            modelBuilder.Entity<RestaurantType>(entity =>
            {
                entity.ToTable("RestaurantType", "restaurant");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('restaurant.\"RestaurantType_ID_seq\"'::regclass)");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.RestaurantType)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("RestaurantType_LanguageID_fkey");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "user");

                entity.HasIndex(e => e.Role1)
                    .HasName("Role_Role_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('\"user\".\"Role_ID_seq\"'::regclass)");

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasColumnName("Role")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<SleepingArrangement>(entity =>
            {
                entity.HasKey(e => e.AccommodationId)
                    .HasName("SleepingArrangement_pkey");

                entity.ToTable("SleepingArrangement", "accommodation");

                entity.Property(e => e.AccommodationId)
                    .HasColumnName("AccommodationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Accommodation)
                    .WithOne(p => p.SleepingArrangement)
                    .HasForeignKey<SleepingArrangement>(d => d.AccommodationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SleepingArrangement_AccommodationID_fkey");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SleepingArrangement)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("SleepingArrangement_LanguageID_fkey");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type", "user");

                entity.HasIndex(e => e.Type1)
                    .HasName("Type_Type_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('\"user\".\"Type_ID_seq\"'::regclass)");

                entity.Property(e => e.Type1)
                    .IsRequired()
                    .HasColumnName("Type")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "user");

                entity.HasIndex(e => e.Email)
                    .HasName("User_Email_key")
                    .IsUnique();

                entity.HasIndex(e => e.Password)
                    .HasName("User_Password_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('\"user\".\"User_ID_seq\"'::regclass)");

                entity.Property(e => e.About).HasColumnType("character varying");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.FacebookId)
                    .HasColumnName("FacebookID")
                    .HasColumnType("character varying");

                entity.Property(e => e.FirstName).HasColumnType("character varying");

                entity.Property(e => e.Gender).HasColumnType("character varying");

                entity.Property(e => e.GoogleId)
                    .HasColumnName("GoogleID")
                    .HasColumnType("character varying");

                entity.Property(e => e.InstagramId)
                    .HasColumnName("InstagramID")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastName).HasColumnType("character varying");

                entity.Property(e => e.LinkedInId)
                    .HasColumnName("LinkedInID")
                    .HasColumnType("character varying");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.ProfilePhoto).HasColumnType("character varying");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TwitterId)
                    .HasColumnName("TwitterID")
                    .HasColumnType("character varying");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.VerificationStatus).HasColumnType("character varying");

                entity.Property(e => e.YahooId)
                    .HasColumnName("YahooID")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_RoleID_fkey");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_TypeID_fkey");
            });

            modelBuilder.HasSequence("Accommodation_ID_seq");

            modelBuilder.HasSequence("AccommodationType_ID_seq");

            modelBuilder.HasSequence("Amenity_ID_seq");

            modelBuilder.HasSequence("HouseRule_ID_seq");

            modelBuilder.HasSequence("Location_ID_seq");

            modelBuilder.HasSequence("Reservation_ID_seq");

            modelBuilder.HasSequence("Activity_ID_seq");

            modelBuilder.HasSequence("ActivityType_ID_seq");

            modelBuilder.HasSequence("Location_ID_seq");

            modelBuilder.HasSequence("Reservation_ID_seq");

            modelBuilder.HasSequence("Category_ID_seq");

            modelBuilder.HasSequence("FoodType_ID_seq");

            modelBuilder.HasSequence("Location_ID_seq");

            modelBuilder.HasSequence("Menu_ID_seq");

            modelBuilder.HasSequence("Reservation_ID_seq");

            modelBuilder.HasSequence("Restaurant_ID_seq");

            modelBuilder.HasSequence("RestaurantType_ID_seq");

            modelBuilder.HasSequence("CardType_ID_seq");

            modelBuilder.HasSequence("Role_ID_seq");

            modelBuilder.HasSequence("Type_ID_seq");

            modelBuilder.HasSequence("User_ID_seq");
        }
    }
}

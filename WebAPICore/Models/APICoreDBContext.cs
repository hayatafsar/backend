using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPICore.Models
{
    public partial class APICoreDBContext : DbContext
    {
        public APICoreDBContext()
        {
        }

        public APICoreDBContext(DbContextOptions<APICoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<TblComment> TblComment { get; set; }
        public virtual DbSet<TblLike> TblLike { get; set; }
        public virtual DbSet<TblMedia> TblMedia { get; set; }
        public virtual DbSet<TblNotification> TblNotification { get; set; }
        public virtual DbSet<TblPost> TblPost { get; set; }
        public virtual DbSet<TblRecord> TblRecord { get; set; }
        public virtual DbSet<TblText> TblText { get; set; }
        public virtual DbSet<TblUserPost> TblUserPost { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }
        public virtual DbSet<TblUsers12> TblUsers12 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=HAYAT\\SQLEXPRESS;Database=APICoreDB;User ID=sa;Password=Welcome@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TblComment>(entity =>
            {
                entity.ToTable("Tbl_Comment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TblLike>(entity =>
            {
                entity.ToTable("Tbl_Like");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TblMedia>(entity =>
            {
                entity.HasKey(e => e.MediaGuid)
                    .HasName("PK__Tbl_Medi__E42F2F4307F6335A");

                entity.ToTable("Tbl_Media");

                entity.Property(e => e.MediaGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MediaDiscription).IsUnicode(false);

                entity.Property(e => e.MediaName).IsUnicode(false);

                entity.Property(e => e.MediaUrl).IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblNotification>(entity =>
            {
                entity.ToTable("Tbl_notification");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasColumnName("isRead");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TblPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__Tbl_Post__3ED7876625869641");

                entity.ToTable("Tbl_Post");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.PostContent).HasColumnName("post_Content");

                entity.Property(e => e.PostImage).HasColumnName("post_Image");

                entity.Property(e => e.PostTitle).HasColumnName("post_Title");
            });

            modelBuilder.Entity<TblRecord>(entity =>
            {
                entity.HasKey(e => e.RecordGuid)
                    .HasName("PK__tbl_Reco__D39156C003317E3D");

                entity.ToTable("Tbl_Record");

                entity.Property(e => e.RecordGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblText>(entity =>
            {
                entity.HasKey(e => e.TextGuid)
                    .HasName("PK__Tbl_Text__21674C640CBAE877");

                entity.ToTable("Tbl_Text");

                entity.Property(e => e.TextGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TextDiscription).IsUnicode(false);

                entity.Property(e => e.TextHeading).IsUnicode(false);
            });

            modelBuilder.Entity<TblUserPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_UserPost");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MediaName).IsUnicode(false);

                entity.Property(e => e.TextDiscription).IsUnicode(false);

                entity.Property(e => e.TextHeading).IsUnicode(false);

                entity.Property(e => e.Userguid).HasColumnName("userguid");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserGuid)
                    .HasName("PK__Tbl_User__99B7F23A3F466844");

                entity.ToTable("Tbl_Users");

                entity.Property(e => e.UserGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.ProfilPictureUrl).HasColumnName("profil_picture_url");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblUsers12>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Users12");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.ProfilPictureUrl).HasColumnName("profil_picture_url");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

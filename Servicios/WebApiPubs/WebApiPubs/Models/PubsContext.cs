﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
        {
        }

        public PubsContext(DbContextOptions<PubsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<TheDiscount> Discounts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<PubInfo> PubInfos { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Roysched> Royscheds { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Titleauthor> Titleauthors { get; set; }
        public virtual DbSet<TheTitle> Titles { get; set; }
        public virtual DbSet<Titleview> Titleviews { get; set; }
        public virtual DbSet<VAuthorsBookTypeCook> VAuthorsBookTypeCook { get; set; }
        public virtual DbSet<VAutorLibros> VAutorLibros { get; set; }
        public virtual DbSet<VListaVentasFechasCantidad> VListaVentasFechasCantidad { get; set; }
        public virtual DbSet<VListadoPublicadoIniciaConB> VListadoPublicadoIniciaConB { get; set; }
        public virtual DbSet<VPublisherTitlesByCity> VPublisherTitlesByCity { get; set; }
        public virtual DbSet<VVentaLibrosCantMayor20> VVentaLibrosCantMayor20 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=.;Database=Pubs;Trusted_Connection=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuId)
                    .HasName("UPKCL_auidind");

                entity.ToTable("authors");

                entity.HasIndex(e => new { e.AuLname, e.AuFname })
                    .HasName("aunmind");

                entity.Property(e => e.AuId)
                    .HasColumnName("au_id")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AuFname)
                    .IsRequired()
                    .HasColumnName("au_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuLname)
                    .IsRequired()
                    .HasColumnName("au_lname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Contract).HasColumnName("contract");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('UNKNOWN')");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TheDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("discounts");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Discounttype)
                    .IsRequired()
                    .HasColumnName("discounttype")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Highqty).HasColumnName("highqty");

                entity.Property(e => e.Lowqty).HasColumnName("lowqty");

                entity.Property(e => e.StorId)
                    .HasColumnName("stor_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Stor)
                    .WithMany()
                    .HasForeignKey(d => d.StorId)
                    .HasConstraintName("FK__discounts__stor___3C69FB99");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK_emp_id")
                    .IsClustered(false);

                entity.ToTable("employee");

                entity.HasIndex(e => new { e.Lname, e.Fname, e.Minit })
                    .HasName("employee_ind")
                    .IsClustered();

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasColumnName("hire_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobLvl)
                    .HasColumnName("job_lvl")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("lname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Minit)
                    .HasColumnName("minit")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PubId)
                    .IsRequired()
                    .HasColumnName("pub_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9952')");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__employee__job_id__48CFD27E");

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__employee__pub_id__4BAC3F29");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK__jobs__6E32B6A501EA857B");

                entity.ToTable("jobs");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.JobDesc)
                    .IsRequired()
                    .HasColumnName("job_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('New Position - title not formalized yet')");

                entity.Property(e => e.MaxLvl).HasColumnName("max_lvl");

                entity.Property(e => e.MinLvl).HasColumnName("min_lvl");
            });

            modelBuilder.Entity<PubInfo>(entity =>
            {
                entity.HasKey(e => e.PubId)
                    .HasName("UPKCL_pubinfo");

                entity.ToTable("pub_info");

                entity.Property(e => e.PubId)
                    .HasColumnName("pub_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("image");

                entity.Property(e => e.PrInfo)
                    .HasColumnName("pr_info")
                    .HasColumnType("text");

                entity.HasOne(d => d.Pub)
                    .WithOne(p => p.PubInfo)
                    .HasForeignKey<PubInfo>(d => d.PubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pub_info__pub_id__440B1D61");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PubId)
                    .HasName("UPKCL_pubind");

                entity.ToTable("publishers");

                entity.Property(e => e.PubId)
                    .HasColumnName("pub_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('USA')");

                entity.Property(e => e.PubName)
                    .HasColumnName("pub_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Roysched>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("roysched");

                entity.HasIndex(e => e.TitleId)
                    .HasName("titleidind");

                entity.Property(e => e.Hirange).HasColumnName("hirange");

                entity.Property(e => e.Lorange).HasColumnName("lorange");

                entity.Property(e => e.Royalty).HasColumnName("royalty");

                entity.Property(e => e.TitleId)
                    .IsRequired()
                    .HasColumnName("title_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Title)
                    .WithMany()
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__roysched__title___3A81B327");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => new { e.StorId, e.OrdNum, e.TitleId })
                    .HasName("UPKCL_sales");

                entity.ToTable("sales");

                entity.HasIndex(e => e.TitleId)
                    .HasName("titleidind");

                entity.Property(e => e.StorId)
                    .HasColumnName("stor_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrdNum)
                    .HasColumnName("ord_num")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TitleId)
                    .HasColumnName("title_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDate)
                    .HasColumnName("ord_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Payterms)
                    .IsRequired()
                    .HasColumnName("payterms")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.HasOne(d => d.Stor)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.StorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sales__stor_id__37A5467C");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sales__title_id__38996AB5");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.StorId)
                    .HasName("UPK_storeid");

                entity.ToTable("stores");

                entity.Property(e => e.StorId)
                    .HasColumnName("stor_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StorAddress)
                    .HasColumnName("stor_address")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StorName)
                    .HasColumnName("stor_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Titleauthor>(entity =>
            {
                entity.HasKey(e => new { e.AuId, e.TitleId })
                    .HasName("UPKCL_taind");

                entity.ToTable("titleauthor");

                entity.HasIndex(e => e.AuId)
                    .HasName("auidind");

                entity.HasIndex(e => e.TitleId)
                    .HasName("titleidind");

                entity.Property(e => e.AuId)
                    .HasColumnName("au_id")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TitleId)
                    .HasColumnName("title_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AuOrd).HasColumnName("au_ord");

                entity.Property(e => e.Royaltyper).HasColumnName("royaltyper");

                entity.HasOne(d => d.Au)
                    .WithMany(p => p.Titleauthor)
                    .HasForeignKey(d => d.AuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__titleauth__au_id__31EC6D26");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Titleauthor)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__titleauth__title__32E0915F");
            });

            modelBuilder.Entity<TheTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId)
                    .HasName("UPKCL_titleidind");

                entity.ToTable("titles");

                entity.HasIndex(e => e.Title)
                    .HasName("titleind");

                entity.Property(e => e.TitleId)
                    .HasColumnName("title_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Advance)
                    .HasColumnName("advance")
                    .HasColumnType("money");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.PubId)
                    .HasColumnName("pub_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pubdate)
                    .HasColumnName("pubdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Royalty).HasColumnName("royalty");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('UNDECIDED')");

                entity.Property(e => e.YtdSales).HasColumnName("ytd_sales");
            });

            modelBuilder.Entity<Titleview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("titleview");

                entity.Property(e => e.AuLname)
                    .IsRequired()
                    .HasColumnName("au_lname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AuOrd).HasColumnName("au_ord");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.PubId)
                    .HasColumnName("pub_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.YtdSales).HasColumnName("ytd_sales");
            });

            modelBuilder.Entity<VAuthorsBookTypeCook>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAuthorsBookTypeCook");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadAutor)
                    .HasColumnName("Ciudad Autor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadPublicador)
                    .HasColumnName("Ciudad Publicador")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAutor)
                    .IsRequired()
                    .HasColumnName("ID Autor")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAutor)
                    .IsRequired()
                    .HasColumnName("Nombre Autor")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Publicador)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Título)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAutorLibros>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAutorLibros");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CódigoLibro)
                    .IsRequired()
                    .HasColumnName("Código Libro")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Título)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VListaVentasFechasCantidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vListaVentasFechasCantidad");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdTitulo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Tienda)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VListadoPublicadoIniciaConB>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vListadoPublicadoIniciaConB");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Publicador)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tiendo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPublisherTitlesByCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPublisherTitlesByCity");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CódigoLibro)
                    .IsRequired()
                    .HasColumnName("Código Libro")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.País)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Publicador)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Título)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VVentaLibrosCantMayor20>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVentaLibrosCantMayor20");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDate)
                    .HasColumnName("ord_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdNum)
                    .IsRequired()
                    .HasColumnName("ord_num")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Publicador)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.StorName)
                    .HasColumnName("stor_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Título)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

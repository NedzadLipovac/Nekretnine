using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Nekretnine.WebApi.Database
{
    public partial class NekretnineContext : DbContext
    {
        public NekretnineContext()
        {
        }

        public NekretnineContext(DbContextOptions<NekretnineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drzava> Drzava { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Komentar> Komentar { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Nekretnina> Nekretnina { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Poruka> Poruka { get; set; }
        public virtual DbSet<Sastanak> Sastanak { get; set; }
        public virtual DbSet<Slika> Slika { get; set; }
        public virtual DbSet<SpaseneNekretnine> SpaseneNekretnine { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<UpitZaSastanak> UpitZaSastanak { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Nekretnine;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grad)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("FK__Grad__DrzavaId__4E88ABD4");
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.Property(e => e.Adresa).HasMaxLength(50);

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ime).HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(50);

                entity.Property(e => e.Prezime).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Klijent)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Klijent__GradId__52593CB8");
            });

            modelBuilder.Entity<Komentar>(entity =>
            {
                entity.Property(e => e.DatumVrijeme).HasColumnType("datetime");

                entity.Property(e => e.Komentar1)
                    .IsRequired()
                    .HasColumnName("Komentar");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Komentar)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Komentar__Klijen__5BE2A6F2");

                entity.HasOne(d => d.Nekretnina)
                    .WithMany(p => p.Komentar)
                    .HasForeignKey(d => d.NekretninaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Komentar__Nekret__5CD6CB2B");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Korisnici__GradI__4F7CD00D");
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.Property(e => e.KorisniciUlogeId).ValueGeneratedNever();

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_KorisniciUloge");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_Uloga");
            });

            modelBuilder.Entity<Nekretnina>(entity =>
            {
                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GodinaIzgradnje)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Vlasnik)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Nekretnina)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Nekretina__GradI__59063A47");
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.Property(e => e.DatumVrijeme).HasColumnType("datetime");

                entity.Property(e => e.Ocjena1).HasColumnName("Ocjena");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocjena__KlijentI__5FB337D6");

                entity.HasOne(d => d.Nekretnina)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.NekretninaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocjena__Nekretni__60A75C0F");
            });

            modelBuilder.Entity<Poruka>(entity =>
            {
                entity.Property(e => e.DatumVrijeme).HasColumnType("datetime");

                entity.Property(e => e.Naslov).HasMaxLength(100);

                entity.Property(e => e.Posiljaoc).HasMaxLength(20);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Poruka)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__Poruka__KlijentI__5535A963");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.Poruka)
                    .HasForeignKey(d => d.UposlenikId)
                    .HasConstraintName("FK__Poruka__Uposleni__5629CD9C");
            });

            modelBuilder.Entity<Sastanak>(entity =>
            {
                entity.Property(e => e.DatumVrijeme).HasColumnType("datetime");

                entity.Property(e => e.Mjesto).IsRequired();

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Sastanak)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sastanak__Klijen__6383C8BA");
            });

            modelBuilder.Entity<Slika>(entity =>
            {
                entity.Property(e => e.NazivSlike).HasColumnName("NazivSlike");

                entity.HasOne(d => d.Nekretnina)
                    .WithMany(p => p.Slika)
                    .HasForeignKey(d => d.NekretninaId)
                    .HasConstraintName("FK_Slika_Nekretnina");
            });

            modelBuilder.Entity<SpaseneNekretnine>(entity =>
            {
                entity.HasKey(e => e.SpasenaNekretninaId)
                    .HasName("PK__SpaseneN__B4B16932FB178C9A");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.SpaseneNekretnine)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SpaseneNe__Klije__66603565");

                entity.HasOne(d => d.Nekretnina)
                    .WithMany(p => p.SpaseneNekretnine)
                    .HasForeignKey(d => d.NekretninaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SpaseneNe__Nekre__6754599E");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.HasKey(e => e.UogaId);

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UpitZaSastanak>(entity =>
            {
                entity.Property(e => e.NazivSastanka).HasMaxLength(100);

                entity.Property(e => e.PredlozeniDatum).HasColumnType("datetime");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.UpitZaSastanak)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__UpitZaSas__Klije__6A30C649");
            });
        }
    }
}

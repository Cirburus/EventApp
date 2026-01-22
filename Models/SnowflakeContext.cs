using Microsoft.EntityFrameworkCore;

namespace EventsApp.Models;

public partial class SnowflakeContext : DbContext
{
    public SnowflakeContext()
    {
    }

    public SnowflakeContext(DbContextOptions<SnowflakeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DatEvent> DatEvents { get; set; }

    public virtual DbSet<DatLocation> DatLocations { get; set; }

    public virtual DbSet<DatRole> DatRoles { get; set; }

    public virtual DbSet<DatSideevent> DatSideevents { get; set; }

    public virtual DbSet<DatTeam> DatTeams { get; set; }

    public virtual DbSet<DatUser> DatUsers { get; set; }

    public virtual DbSet<MapEventlocation> MapEventlocations { get; set; }

    public virtual DbSet<MapEventsideevent> MapEventsideevents { get; set; }

    public virtual DbSet<MapEventsideeventuser> MapEventsideeventusers { get; set; }

    public virtual DbSet<MapEventteamuser> MapEventteamusers { get; set; }

    public virtual DbSet<MapEventuser> MapEventusers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("EVENTSAPP");

        modelBuilder.Entity<DatEvent>(entity =>
        {
            entity.HasKey(e => e.Eventid).HasName("SYS_CONSTRAINT_ac76d4d1-1630-46ef-a5e4-3f4e04cfaddc");

            entity.ToTable("DAT_EVENT");

            entity.Property(e => e.Eventid)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("EVENTID");
            entity.Property(e => e.Eventcost)
                .HasPrecision(38)
                .HasColumnName("EVENTCOST");
            entity.Property(e => e.Eventdesc)
                .HasMaxLength(255)
                .HasColumnName("EVENTDESC");
            entity.Property(e => e.Eventend).HasColumnName("EVENTEND");
            entity.Property(e => e.Eventname)
                .HasMaxLength(20)
                .HasColumnName("EVENTNAME");
            entity.Property(e => e.Eventstart).HasColumnName("EVENTSTART");
        });

        modelBuilder.Entity<DatLocation>(entity =>
        {
            entity.HasKey(e => e.Locationid).HasName("SYS_CONSTRAINT_d082a293-d8bd-4531-8502-d17d075c4562");

            entity.ToTable("DAT_LOCATION");

            entity.Property(e => e.Locationid)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("LOCATIONID");
            entity.Property(e => e.Locationaddress1)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONADDRESS1");
            entity.Property(e => e.Locationaddress2)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONADDRESS2");
            entity.Property(e => e.Locationcity)
                .HasMaxLength(20)
                .HasColumnName("LOCATIONCITY");
            entity.Property(e => e.Locationemail)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONEMAIL");
            entity.Property(e => e.Locationname)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONNAME");
            entity.Property(e => e.Locationphone)
                .HasMaxLength(14)
                .HasColumnName("LOCATIONPHONE");
            entity.Property(e => e.Locationpostcode)
                .HasMaxLength(10)
                .HasColumnName("LOCATIONPOSTCODE");
            entity.Property(e => e.Locationremote)
                .HasMaxLength(20)
                .HasColumnName("LOCATIONREMOTE");
            entity.Property(e => e.Locationstateprov)
                .HasMaxLength(20)
                .HasColumnName("LOCATIONSTATEPROV");
        });

        modelBuilder.Entity<DatRole>(entity =>
        {
            entity.HasKey(e => e.Roleid).HasName("SYS_CONSTRAINT_4108a80a-0971-4aa5-9238-8887cc26873b");

            entity.ToTable("DAT_ROLE");

            entity.Property(e => e.Roleid)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("ROLEID");
            entity.Property(e => e.Roledesc)
                .HasMaxLength(255)
                .HasColumnName("ROLEDESC");
            entity.Property(e => e.Rolename)
                .HasMaxLength(20)
                .HasColumnName("ROLENAME");
        });

        modelBuilder.Entity<DatSideevent>(entity =>
        {
            entity.HasKey(e => e.Sideeventid).HasName("SYS_CONSTRAINT_469cadd1-282a-496d-9d63-d8f3690a375a");

            entity.ToTable("DAT_SIDEEVENT");

            entity.Property(e => e.Sideeventid)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("SIDEEVENTID");
            entity.Property(e => e.Sideeventcost)
                .HasPrecision(38)
                .HasColumnName("SIDEEVENTCOST");
            entity.Property(e => e.Sideeventdesc)
                .HasMaxLength(255)
                .HasColumnName("SIDEEVENTDESC");
            entity.Property(e => e.Sideeventname)
                .HasMaxLength(20)
                .HasColumnName("SIDEEVENTNAME");
        });

        modelBuilder.Entity<DatTeam>(entity =>
        {
            entity.HasKey(e => e.Teamid).HasName("SYS_CONSTRAINT_f9bfe607-791d-4386-87f0-5861a9a8c56a");

            entity.ToTable("DAT_TEAM");

            entity.Property(e => e.Teamid)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(20)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<DatUser>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("SYS_CONSTRAINT_95fad561-982d-4f4a-976d-8eefc31552d0");

            entity.ToTable("DAT_USER");

            entity.Property(e => e.Userid)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("USERID");
            entity.Property(e => e.Fname)
                .HasMaxLength(20)
                .HasColumnName("FNAME");
            entity.Property(e => e.Lname)
                .HasMaxLength(20)
                .HasColumnName("LNAME");
        });

        modelBuilder.Entity<MapEventlocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MAP_EVENTLOCATION");

            entity.Property(e => e.Eventid)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.Locationid)
                .HasPrecision(38)
                .HasColumnName("LOCATIONID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.Eventid)
                .HasConstraintName("EVENTLOCATIONEVENTID");

            entity.HasOne(d => d.Location).WithMany()
                .HasForeignKey(d => d.Locationid)
                .HasConstraintName("EVENTLOCATIONLOCATIONID");
        });

        modelBuilder.Entity<MapEventsideevent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MAP_EVENTSIDEEVENT");

            entity.Property(e => e.Eventid)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.Sideeventid)
                .HasPrecision(38)
                .HasColumnName("SIDEEVENTID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.Eventid)
                .HasConstraintName("EVENTSIDEEVENTEVENTID");

            entity.HasOne(d => d.Sideevent).WithMany()
                .HasForeignKey(d => d.Sideeventid)
                .HasConstraintName("EVENTSIDEEVENTSIDEEVENTID");
        });

        modelBuilder.Entity<MapEventsideeventuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MAP_EVENTSIDEEVENTUSER");

            entity.Property(e => e.Eventid)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.Sideeventid)
                .HasPrecision(38)
                .HasColumnName("SIDEEVENTID");
            entity.Property(e => e.Userid)
                .HasPrecision(38)
                .HasColumnName("USERID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.Eventid)
                .HasConstraintName("EVENTSIDEEVENTUSEREVENTID");

            entity.HasOne(d => d.Sideevent).WithMany()
                .HasForeignKey(d => d.Sideeventid)
                .HasConstraintName("EVENTSIDEEVENTUSERSIDEEVENTID");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("EVENTSIDEEVENTUSERUSERID");
        });

        modelBuilder.Entity<MapEventteamuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MAP_EVENTTEAMUSER");

            entity.Property(e => e.Eventid)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.Teamid)
                .HasPrecision(38)
                .HasColumnName("TEAMID");
            entity.Property(e => e.Userid)
                .HasPrecision(38)
                .HasColumnName("USERID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.Eventid)
                .HasConstraintName("EVENTTEAMUSEREVENTID");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.Teamid)
                .HasConstraintName("EVENTTEAMUSERTEAMID");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("EVENTTEAMUSERUSERID");
        });

        modelBuilder.Entity<MapEventuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MAP_EVENTUSER");

            entity.Property(e => e.Eventid)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.Userid)
                .HasPrecision(38)
                .HasColumnName("USERID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.Eventid)
                .HasConstraintName("EVENTUSEREVENTIDFK");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("EVENTUSERUSERIDFK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
}

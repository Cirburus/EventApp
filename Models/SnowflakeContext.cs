using EventsApp.Models.DAT;
using EventsApp.Models.MAP;
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

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SideEvent> SideEvents { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<EventLocation> EventLocations { get; set; }

    public virtual DbSet<EventSideEvent> EventEideEvents { get; set; }

    public virtual DbSet<EventSideEvent> EventSideEventUsers { get; set; }

    public virtual DbSet<EventTeamUser> EventTeamUsers { get; set; }

    public virtual DbSet<EventUser> EventUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("EVENTSAPP");

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("SYS_CONSTRAINT_ac76d4d1-1630-46ef-a5e4-3f4e04cfaddc");

            entity.ToTable("EVENT", schema: "EVENTSAPP_DAT");

            entity.Property(e => e.EventId)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("EVENTID");
            entity.Property(e => e.EventCost)
                .HasPrecision(38)
                .HasColumnName("EVENTCOST");
            entity.Property(e => e.EventDesc)
                .HasMaxLength(255)
                .HasColumnName("EVENTDESC");
            entity.Property(e => e.EventEnd).HasColumnName("EVENTEND");
            entity.Property(e => e.EventName)
                .HasMaxLength(20)
                .HasColumnName("EVENTNAME");
            entity.Property(e => e.EventStart).HasColumnName("EVENTSTART");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("SYS_CONSTRAINT_d082a293-d8bd-4531-8502-d17d075c4562");

            entity.ToTable("LOCATION", schema: "EVENTSAPP_DAT");

            entity.Property(e => e.LocationId)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("LOCATIONID");
            entity.Property(e => e.LocationAddress1)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONADDRESS1");
            entity.Property(e => e.LocationAddress2)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONADDRESS2");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(20)
                .HasColumnName("LOCATIONCITY");
            entity.Property(e => e.LocationEmail)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONEMAIL");
            entity.Property(e => e.LocationName)
                .HasMaxLength(255)
                .HasColumnName("LOCATIONNAME");
            entity.Property(e => e.LocationPhone)
                .HasMaxLength(14)
                .HasColumnName("LOCATIONPHONE");
            entity.Property(e => e.LocationPostCode)
                .HasMaxLength(10)
                .HasColumnName("LOCATIONPOSTCODE");
            entity.Property(e => e.LocationRemote)
                .HasMaxLength(20)
                .HasColumnName("LOCATIONREMOTE");
            entity.Property(e => e.LocationStateProv)
                .HasMaxLength(20)
                .HasColumnName("LOCATIONSTATEPROV");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("SYS_CONSTRAINT_4108a80a-0971-4aa5-9238-8887cc26873b");

            entity.ToTable("ROLE", schema: "EVENTSAPP_DAT");

            entity.Property(e => e.RoleId)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("ROLEID");
            entity.Property(e => e.RoleDesc)
                .HasMaxLength(255)
                .HasColumnName("ROLEDESC");
            entity.Property(e => e.RoleName)
                .HasMaxLength(20)
                .HasColumnName("ROLENAME");
        });

        modelBuilder.Entity<SideEvent>(entity =>
        {
            entity.HasKey(e => e.SideEventId).HasName("SYS_CONSTRAINT_469cadd1-282a-496d-9d63-d8f3690a375a");

            entity.ToTable("SIDEEVENT", schema: "EVENTSAPP_DAT");

            entity.Property(e => e.SideEventId)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("SIDEEVENTID");
            entity.Property(e => e.SideEventCost)
                .HasPrecision(38)
                .HasColumnName("SIDEEVENTCOST");
            entity.Property(e => e.SideEventDesc)
                .HasMaxLength(255)
                .HasColumnName("SIDEEVENTDESC");
            entity.Property(e => e.SideEventName)
                .HasMaxLength(20)
                .HasColumnName("SIDEEVENTNAME");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("SYS_CONSTRAINT_f9bfe607-791d-4386-87f0-5861a9a8c56a");

            entity.ToTable("TEAM", schema: "EVENTSAPP_DAT");

            entity.Property(e => e.TeamId)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("TEAMID");
            entity.Property(e => e.TeamName)
                .HasMaxLength(20)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("SYS_CONSTRAINT_95fad561-982d-4f4a-976d-8eefc31552d0");

            entity.ToTable("USER", schema: "EVENTSAPP_DAT");

            entity.Property(e => e.UserId)
                .HasPrecision(38)
                .UseIdentityColumn(1L, 1, false)
                .HasColumnName("USERID");
            entity.Property(e => e.FName)
                .HasMaxLength(20)
                .HasColumnName("FNAME");
            entity.Property(e => e.LName)
                .HasMaxLength(20)
                .HasColumnName("LNAME");
        });

        modelBuilder.Entity<EventLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EVENTLOCATION", schema: "EVENTSAPP_MAP");

            entity.Property(e => e.EventId)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.LocationId)
                .HasPrecision(38)
                .HasColumnName("LOCATIONID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("EVENTLOCATION_EVENTID");

            entity.HasOne(d => d.Location).WithMany()
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("EVENTLOCATION_LOCATIONID");
        });

        modelBuilder.Entity<EventSideEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EVENTSIDEEVENT", schema: "EVENTSAPP_MAP");

            entity.Property(e => e.EventId)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.SideEventId)
                .HasPrecision(38)
                .HasColumnName("SIDEEVENTID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("EVENTSIDEEVENT_EVENTID");

            entity.HasOne(d => d.SideEvent).WithMany()
                .HasForeignKey(d => d.SideEventId)
                .HasConstraintName("EVENTSIDEEVENT_SIDEEVENTID");
        });

        modelBuilder.Entity<EventSideEventUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EVENTSIDEEVENTUSER", schema: "EVENTSAPP_MAP");

            entity.Property(e => e.EventId)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.SideEventId)
                .HasPrecision(38)
                .HasColumnName("SIDEEVENTID");
            entity.Property(e => e.UserId)
                .HasPrecision(38)
                .HasColumnName("USERID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("EVENTSIDEEVENTUSER_EVENTID");

            entity.HasOne(d => d.SideEvent).WithMany()
                .HasForeignKey(d => d.SideEventId)
                .HasConstraintName("EVENTSIDEEVENTUSER_SIDEEVENTID");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("EVENTSIDEEVENTUSER_USERID");
        });

        modelBuilder.Entity<EventTeamUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EVENTTEAMUSER", schema: "EVENTSAPP_MAP");

            entity.Property(e => e.EventId)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.TeamId)
                .HasPrecision(38)
                .HasColumnName("TEAMID");
            entity.Property(e => e.UserId)
                .HasPrecision(38)
                .HasColumnName("USERID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("EVENTTEAMUSER_EVENTID");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("EVENTTEAMUSER_TEAMID");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("EVENTTEAMUSER_USERID");
        });

        modelBuilder.Entity<EventUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EVENTUSER", schema: "EVENTSAPP_MAP");

            entity.Property(e => e.EventId)
                .HasPrecision(38)
                .HasColumnName("EVENTID");
            entity.Property(e => e.UserId)
                .HasPrecision(38)
                .HasColumnName("USERID");

            entity.HasOne(d => d.Event).WithMany()
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("EVENTUSER_EVENTID");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("EVENTUSER_USERID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
}

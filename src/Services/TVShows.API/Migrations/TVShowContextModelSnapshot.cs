﻿// <auto-generated />

namespace AUTOPAL.RTL.TVMaze.Services.TVShows.API.Migrations
{
    using System;
    using AUTOPAL.RTL.TVMaze.Services.TVShows.API.Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;

    [DbContext(contextType: typeof(TVShowContext))]
    internal class TVShowContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation(annotation: "ProductVersion", value: "2.1.3-rtm-32065")
                .HasAnnotation(annotation: "Relational:MaxIdentifierLength", value: 128)
                .HasAnnotation(annotation: "SqlServer:ValueGenerationStrategy",
                    value: SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity(name: "AUTOPOAL.RTL.TVMaze.Services.TVShows.API.Model.Person", buildAction: b =>
            {
                b.Property<int>(propertyName: "Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation(annotation: "SqlServer:ValueGenerationStrategy",
                        value: SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>(propertyName: "BirthDate");

                b.Property<string>(propertyName: "Name")
                    .IsRequired();

                b.Property<int>(propertyName: "TVMazeId");

                b.HasKey("Id");

                b.ToTable(name: "Person");
            });

            modelBuilder.Entity(name: "AUTOPOAL.RTL.TVMaze.Services.TVShows.API.Model.Show", buildAction: b =>
            {
                b.Property<int>(propertyName: "Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation(annotation: "SqlServer:ValueGenerationStrategy",
                        value: SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>(propertyName: "Name")
                    .IsRequired();

                b.Property<int>(propertyName: "TVMazeId");

                b.Property<long>(propertyName: "Timestamp");

                b.HasKey("Id");

                b.ToTable(name: "Show");
            });

            modelBuilder.Entity(name: "AUTOPOAL.RTL.TVMaze.Services.TVShows.API.Model.ShowPerson", buildAction: b =>
            {
                b.Property<int>(propertyName: "PersonId");

                b.Property<int>(propertyName: "ShowId");

                b.HasKey("PersonId", "ShowId");

                b.HasIndex("ShowId");

                b.ToTable(name: "ShowPerson");
            });

            modelBuilder.Entity(name: "AUTOPOAL.RTL.TVMaze.Services.TVShows.API.Model.ShowPerson", buildAction: b =>
            {
                b.HasOne(relatedTypeName: "AUTOPOAL.RTL.TVMaze.Services.TVShows.API.Model.Person",
                        navigationName: "Person")
                    .WithMany(collection: "Shows")
                    .HasForeignKey("PersonId")
                    .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

                b.HasOne(relatedTypeName: "AUTOPOAL.RTL.TVMaze.Services.TVShows.API.Model.Show", navigationName: "Show")
                    .WithMany(collection: "Persons")
                    .HasForeignKey("ShowId")
                    .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}
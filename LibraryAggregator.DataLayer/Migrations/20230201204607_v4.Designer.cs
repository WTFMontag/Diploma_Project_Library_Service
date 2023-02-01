﻿// <auto-generated />
using System;
using LibraryAggregator.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    [DbContext(typeof(LibraryDataBaseContext))]
    [Migration("20230201204607_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AuthorId")
                        .HasName("PK__Author__70DAFC34E9BADC14");

                    b.ToTable("Author", (string)null);

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Лев",
                            LastName = "Толстой",
                            MiddleName = "Николаевич"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Антон",
                            LastName = "Чехов",
                            MiddleName = "Павлович"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Джефри",
                            LastName = "Рихтер"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Михаил",
                            LastName = "Булгаков",
                            MiddleName = "Афанасьевич"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.AuthorsBook", b =>
                {
                    b.Property<int>("AuthorsBooksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorsBooksId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsBooksId")
                        .HasName("PK__AuthorsB__E0C25E886755A2F4");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorsBooks");

                    b.HasData(
                        new
                        {
                            AuthorsBooksId = 1,
                            AuthorId = 1,
                            BookId = 1
                        },
                        new
                        {
                            AuthorsBooksId = 2,
                            AuthorId = 2,
                            BookId = 2
                        },
                        new
                        {
                            AuthorsBooksId = 3,
                            AuthorId = 3,
                            BookId = 3
                        },
                        new
                        {
                            AuthorsBooksId = 4,
                            AuthorId = 4,
                            BookId = 4
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("CoverImgPath")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(23)
                        .HasColumnType("nvarchar(23)")
                        .HasColumnName("ISBN");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BookId")
                        .HasName("PK__Book__3DE0C207BE51473D");

                    b.HasIndex(new[] { "Isbn" }, "UQ__Book__447D36EA06ADE972")
                        .IsUnique();

                    b.ToTable("Book", (string)null);

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            CoverImgPath = "https://yandex.by/images/search?from=tabbar&text=%D0%90%D0%BD%D0%BD%D0%B0%20%D0%9A%D0%B0%D1%80%D0%B5%D0%BD%D0%B8%D0%BD%D0%B0%20%D0%9B%D0%B5%D0%B2%20%D0%A2%D0%BE%D0%BB%D1%81%D1%82%D0%BE%D0%B9%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&pos=2&img_url=http%3A%2F%2Fzvuk-knigi.ru%2Fuploads%2Fposts%2F2022-05%2F1653796476_2022-05-29_074809.jpg&rpt=simage&lr=157",
                            Description = "Любовь",
                            Isbn = "978-5-9268-2544-9",
                            PageCount = 1130,
                            PublishDate = new DateTime(1877, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Анна Каренина"
                        },
                        new
                        {
                            BookId = 2,
                            CoverImgPath = "https://yandex.by/images/search?from=tabbar&text=%D0%A7%D0%B5%D0%BB%D0%BE%D0%B2%D0%B5%D0%BA%20%D0%B2%20%D1%84%D1%83%D1%82%D0%BB%D1%8F%D1%80%D1%83&pos=2&img_url=http%3A%2F%2Flookaside.fbsbx.com%2Flookaside%2Fcrawler%2Fmedia%2F%3Fmedia_id%3D423641392452979&rpt=simage&lr=157",
                            Description = "Ошибки",
                            Isbn = "978-5-389-16173-3",
                            PageCount = 960,
                            PublishDate = new DateTime(1898, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Человек в футляре"
                        },
                        new
                        {
                            BookId = 3,
                            CoverImgPath = "https://yandex.by/images/search?from=tabbar&text=clr%20via%20c%23&pos=2&img_url=http%3A%2F%2Fplaybook.storage.yandexcloud.net%2Fiblock%2F659%2F65957062197947140c473640bdc33b7e%2F46772ad509f580644212f1610e05b107.jpg&rpt=simage&lr=157",
                            Description = "Хорошо",
                            Isbn = "978-5-7502-0348-2",
                            PageCount = 896,
                            PublishDate = new DateTime(2008, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "CLR via C#"
                        },
                        new
                        {
                            BookId = 4,
                            CoverImgPath = "https://yandex.by/images/search?text=%D0%BC%D0%B0%D1%81%D1%82%D0%B5%D1%80%20%D0%B8%20%D0%BC%D0%B0%D1%80%D0%B3%D0%B0%D1%80%D0%B8%D1%82%D0%B0%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&from=tabbar&pos=1&img_url=http%3A%2F%2Fmam4.ru%2Fresize%2F1280x-%2Fhttps%2Fwww.mam4.ru%2Fmedia%2Fupload%2Fuser%2F10807%2Fff%2F1631437479291.jpg%3Fh%3D68QJBhpTmqP34bJHHh-6ig&rpt=simage&lr=157",
                            Description = "Мастер крут",
                            Isbn = "978-5-04-102789-6",
                            PageCount = 1130,
                            PublishDate = new DateTime(1966, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Мастер и Маргарита"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.BooksGenre", b =>
                {
                    b.Property<int>("BooksGenresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BooksGenresId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("BooksGenresId")
                        .HasName("PK__BooksGen__8D4DA176FE0124EF");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("BooksGenres");

                    b.HasData(
                        new
                        {
                            BooksGenresId = 1,
                            BookId = 1,
                            GenreId = 4
                        },
                        new
                        {
                            BooksGenresId = 2,
                            BookId = 2,
                            GenreId = 5
                        },
                        new
                        {
                            BooksGenresId = 3,
                            BookId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            BooksGenresId = 4,
                            BookId = 4,
                            GenreId = 2
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.BooksLibrary", b =>
                {
                    b.Property<int>("BooksLibrariesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BooksLibrariesId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.HasKey("BooksLibrariesId")
                        .HasName("PK__BooksLib__D9FCBEB6058BCAE3");

                    b.HasIndex("BookId");

                    b.HasIndex("LibraryId");

                    b.ToTable("BooksLibraries");

                    b.HasData(
                        new
                        {
                            BooksLibrariesId = 1,
                            BookId = 1,
                            LibraryId = 1
                        },
                        new
                        {
                            BooksLibrariesId = 2,
                            BookId = 2,
                            LibraryId = 1
                        },
                        new
                        {
                            BooksLibrariesId = 3,
                            BookId = 3,
                            LibraryId = 1
                        },
                        new
                        {
                            BooksLibrariesId = 4,
                            BookId = 4,
                            LibraryId = 1
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId")
                        .HasName("PK__Genre__0385057E1C92AF8D");

                    b.ToTable("Genre", (string)null);

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Type = "Любовный роман"
                        },
                        new
                        {
                            GenreId = 2,
                            Type = "Модернизм в литературе"
                        },
                        new
                        {
                            GenreId = 3,
                            Type = "Техническая литература"
                        },
                        new
                        {
                            GenreId = 4,
                            Type = "роман"
                        },
                        new
                        {
                            GenreId = 5,
                            Type = "рассказ"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.ImagesFourCorusel", b =>
                {
                    b.Property<int>("ImagesFourCoruselId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImagesFourCoruselId"));

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImagesFourCoruselId");

                    b.HasIndex("LibraryId");

                    b.ToTable("ImagesFourCorusel");

                    b.HasData(
                        new
                        {
                            ImagesFourCoruselId = 1,
                            LibraryId = 1,
                            Link = "https://nashaniva.com/photos/generated/fb249647.png"
                        },
                        new
                        {
                            ImagesFourCoruselId = 2,
                            LibraryId = 1,
                            Link = "http://knigoplaneta.ru/wp-content/uploads/2015/05/DSC_0253.jpg"
                        },
                        new
                        {
                            ImagesFourCoruselId = 3,
                            LibraryId = 1,
                            Link = "http://s4.fotokto.ru/photo/full/492/4927138.jpg"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Library", b =>
                {
                    b.Property<int>("LibraryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibraryId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgeGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChartLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorPhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HistoryOfLibrary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LibraryId")
                        .HasName("PK__Library__A136475FA23EBF26");

                    b.ToTable("Library", (string)null);

                    b.HasData(
                        new
                        {
                            LibraryId = 1,
                            Address = "просп.Независимости, 11б",
                            AgeGroup = "Нет ограничений ",
                            ChartLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
                            DirectorPhotoLink = "https://yandex.by/images/search?pos=1&img_url=http%3A%2F%2Fculturalforum.ru%2Fcontent%2Fparticipants%2Fcc%2Fccbd7c9088e9e70148120c9eaaa5064b-cropped.jpg&text=%D0%9A%D0%BD%D0%B8%D0%B6%D0%BD%D0%B8%D0%BA%D0%BE%D0%B2%D0%B0%20%D0%9E%D0%BA%D1%81%D0%B0%D0%BD%D0%B0%20%D0%AE%D1%80%D1%8C%D0%B5%D0%B2%D0%BD%D0%B0&lr=157&rpt=simage&source=serp",
                            Email = "www.nlb.by",
                            HistoryOfLibrary = "Национальная библиотека Беларуси (НББ) была основана постановлением Совета народных комиссаров БССР в 1922 году как Белорусская государственная и университетская библиотека Белорусского государственного университета (БГУ). На момент открытия фонды библиотеки насчитывали всего 60 тысяч экземпляров, которыми пользовались 1,1 тысячи человек. Первым собственным зданием библиотеки стал Юбилейный дом на Захарьевской улице (ныне — проспект Независимости). Постановлением СНК БССР от 14 мая 1926 году библиотека была выведена из состава БГУ и реорганизована в Белорусскую государственную библиотеку. В 1932 году библиотеке было присвоено имя В. И. Ленина. В тот же год библиотека получила новое здание архитектора Г. Лаврова в конструктивистском стиле. ",
                            Name = "Национальная библиотека Минска",
                            PhoneNumber = "+375 17 368-37-37"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.OperatingModes", b =>
                {
                    b.Property<int>("OperatingModeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperatingModeId"));

                    b.Property<string>("CleanUpDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("StartWork")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OperatingModeId");

                    b.HasIndex("LibraryId");

                    b.ToTable("OperatingModes");

                    b.HasData(
                        new
                        {
                            OperatingModeId = 1,
                            CleanUpDay = "Понедельник",
                            EndWork = "20:00",
                            LibraryId = 1,
                            StartWork = "8:00"
                        },
                        new
                        {
                            OperatingModeId = 2,
                            CleanUpDay = "Пятница",
                            EndWork = "22:00",
                            LibraryId = 1,
                            StartWork = "10:00"
                        },
                        new
                        {
                            OperatingModeId = 3,
                            CleanUpDay = "Среда",
                            EndWork = "22:00",
                            LibraryId = 1,
                            StartWork = "10:00"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.AuthorsBook", b =>
                {
                    b.HasOne("LibraryAggregator.DataLayer.Entities.Author", "Author")
                        .WithMany("AuthorsBooks")
                        .HasForeignKey("AuthorId")
                        .IsRequired()
                        .HasConstraintName("FK__AuthorsBo__Autho__3B75D760");

                    b.HasOne("LibraryAggregator.DataLayer.Entities.Book", "Book")
                        .WithMany("AuthorsBooks")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK__AuthorsBo__BookI__3C69FB99");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.BooksGenre", b =>
                {
                    b.HasOne("LibraryAggregator.DataLayer.Entities.Book", "Book")
                        .WithMany("BooksGenres")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK__BooksGenr__BookI__46E78A0C");

                    b.HasOne("LibraryAggregator.DataLayer.Entities.Genre", "Genre")
                        .WithMany("BooksGenres")
                        .HasForeignKey("GenreId")
                        .IsRequired()
                        .HasConstraintName("FK__BooksGenr__Genre__47DBAE45");

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.BooksLibrary", b =>
                {
                    b.HasOne("LibraryAggregator.DataLayer.Entities.Book", "Book")
                        .WithMany("BooksLibraries")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK__BooksLibr__BookI__412EB0B6");

                    b.HasOne("LibraryAggregator.DataLayer.Entities.Library", "Library")
                        .WithMany("BooksLibraries")
                        .HasForeignKey("LibraryId")
                        .IsRequired()
                        .HasConstraintName("FK__BooksLibr__Libra__4222D4EF");

                    b.Navigation("Book");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.ImagesFourCorusel", b =>
                {
                    b.HasOne("LibraryAggregator.DataLayer.Entities.Library", "Library")
                        .WithMany("ImagesForCorusel")
                        .HasForeignKey("LibraryId");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.OperatingModes", b =>
                {
                    b.HasOne("LibraryAggregator.DataLayer.Entities.Library", "Libraries")
                        .WithMany("OperatingModes")
                        .HasForeignKey("LibraryId");

                    b.Navigation("Libraries");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Author", b =>
                {
                    b.Navigation("AuthorsBooks");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Book", b =>
                {
                    b.Navigation("AuthorsBooks");

                    b.Navigation("BooksGenres");

                    b.Navigation("BooksLibraries");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Genre", b =>
                {
                    b.Navigation("BooksGenres");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Library", b =>
                {
                    b.Navigation("BooksLibraries");

                    b.Navigation("ImagesForCorusel");

                    b.Navigation("OperatingModes");
                });
#pragma warning restore 612, 618
        }
    }
}

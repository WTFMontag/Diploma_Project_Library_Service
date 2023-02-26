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
    [Migration("20230226181345_deleteBookingStatusId")]
    partial class deleteBookingStatusId
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

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId")
                        .HasName("PK__Author__70DAFC34E9BADC14");

                    b.ToTable("Author", (string)null);

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Biography = "Один из наиболее широко известных русских писателей и мыслителей, почитаемый как один из величайших писателей мира. Участник обороны Севастополя. Просветитель, публицист, религиозный мыслитель, чьё авторитетное мнение послужило причиной возникновения нового религиозно-нравственного течения — толстовства. Член-корреспондент Императорской Академии наук (1873), почётный академик по разряду изящной словесности (1900).",
                            CoverImgPath = "Assets/Images/Authors/lev-tolstoy.jpg",
                            DateOfBirth = new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Лев",
                            LastName = "Толстой",
                            MiddleName = "Николаевич"
                        },
                        new
                        {
                            AuthorId = 2,
                            Biography = "Антон Павлович Чехов родился в Таганроге. Обучался в греческой школе, затем в классической гимназии. В 1876 году отец Чехова разорился и был вынужден бежать в Москву, а Антон Павлович остался в Таганроге. Свои первые литературные работы Чехов под разными псевдонимами посылает в столичные журналы; среди его первых произведений не сохранившиеся комедии \"Нашла коса на камень\" и \"Недаром курица пела\", в так же солидная драма \"Безотцовщина\".",
                            CoverImgPath = "Assets/Images/Authors/anton-chekhov.jpg",
                            DateOfBirth = new DateTime(1860, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Антон",
                            LastName = "Чехов",
                            MiddleName = "Павлович"
                        },
                        new
                        {
                            AuthorId = 3,
                            Biography = "Джеффри Рихтер – программист, автор самых известных книг о Win32 и .NET. Рихтер – один из учредителей компании Wintellect, занимающейся подготовкой IT-специалистов и предоставлением консалтинговых услуг фирмам-разработчикам ПО. Рихтер работал с такими компаниями как Intel, DreamWorks и Microsoft.",
                            CoverImgPath = "Assets/Images/Authors/dzheffri-rihter.jpg",
                            DateOfBirth = new DateTime(1964, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Джефри",
                            LastName = "Рихтер"
                        },
                        new
                        {
                            AuthorId = 4,
                            Biography = "Учился в Первой Киевской гимназии, позднее — на медицинском факультете Киевского университета. Первую пробу пера совершил в семилетнем возрасте, написав рассказ «Похождения Светланы».",
                            CoverImgPath = "Assets/Images/Authors/mikhail-bulgakov.jpg",
                            DateOfBirth = new DateTime(1891, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                        },
                        new
                        {
                            AuthorsBooksId = 5,
                            AuthorId = 1,
                            BookId = 5
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("CoverImgPath")
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<string>("Description")
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

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

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId")
                        .HasName("PK__Book__3DE0C207BE51473D");

                    b.HasIndex(new[] { "Isbn" }, "UQ__Book__447D36EA06ADE972")
                        .IsUnique();

                    b.ToTable("Book", (string)null);

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            CoverImgPath = "Assets/Images/Books/Anna_Karenina.jpg",
                            Description = "Роман Льва Толстого о трагической любви замужней дамы Анны Карениной и \r\nблестящего офицера Алексея Вронского на фоне счастливой семейной жизни дворян Константина Лёвина\r\n и Кити Щербацкой. Масштабная картина нравов и быта дворянской среды Петербурга и Москвы второй половины XIX века, \r\nсочетающая философские размышления авторского alter ego Лёвина с передовыми в русской литературе психологическими зарисовками, а также сценами из жизни крестьян.",
                            Isbn = "978-5-9268-2544-1",
                            PageCount = 1130,
                            PublishDate = new DateTime(1877, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Анна Каренина"
                        },
                        new
                        {
                            BookId = 2,
                            CoverImgPath = "Assets/Images/Books/TheManInTheCase.jpg",
                            Description = "Серия «Маленькая трилогия», состоящая из трёх рассказов — «Человек в футляре», \r\n«Крыжовник», «О любви» — не должна была оканчиваться рассказом «О любви». \r\nВо время написания рассказов произошёл спад активности творчества, а позднее Чехова отвлекло заболевание туберкулезом.\r\nНад рассказом Чехов работал в мае — июне 1898 года в Мелихове. В начале июня 1898 года рассказ готовился к печати, а 15 июня 1898 года рукопись была отправлена в ж",
                            Isbn = "978-5-389-16173-2",
                            PageCount = 960,
                            PublishDate = new DateTime(1898, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Человек в футляре"
                        },
                        new
                        {
                            BookId = 3,
                            CoverImgPath = "Assets/Images/Books/CLR-via-C#-1.jpg",
                            Description = "Эта книга, выходящая в третьем издании и уже ставшая классическим учебником по программированию,\r\n подробно описывает внутреннее устройство и функционирование общеязыковой исполняющей среды (CLR) Microsoft .NET Framework версии 4.0. \r\nНаписанная признанным экспертом в области программирования Джеффри Рихтером, много лет являющимся консультантом команды разработчиков .NET Framework компании Microsoft, \r\nкнига научит вас создавать по-настоящему надежные приложения любого вида, в том числе с использованием Microsoft Silverlight, ASP.NET, Windows Presentation Foundation и т.д.\r\nТретье издание полностью обновлено в соответствии со спецификацией платформы .NET Framework 4.0 и принципами многоядерного программирования.",
                            Isbn = "978-5-7502-0348-1",
                            PageCount = 896,
                            PublishDate = new DateTime(2008, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "CLR via C#"
                        },
                        new
                        {
                            BookId = 4,
                            CoverImgPath = "Assets/Images/Books/The%20master%20and%20margarita.jpg",
                            Description = "«Ма́стер и Маргари́та» — роман Михаила Афанасьевича Булгакова, работа над которым началась в декабре 1928 года и продолжалась вплоть до смерти писателя в марте 1940 года.\r\n Роман относится к незавершённым произведениям; редактирование и сведение воедино черновых записей осуществляла после смерти мужа вдова писателя — Елена Сергеевна. \r\nПервая версия романа, имевшая названия «Копыто инженера», «Чёрный маг» и другие, была уничтожена Булгаковым в 1930 году. \r\nВ последующих редакциях среди героев произведения появились автор романа о Понтии Пилате и его возлюбленная. Окончательное название — «Мастер и Маргарита» — оформилось в 1937 году.\r\n\r\nПервая публикация произведения в сокращённом виде была осуществлена в 1966—1967 годах (журнал «Москва», предисловие Константина Симонова, послесловие Абрама Вулиса). \r\nПервое полное издание книги на русском языке вышло в 1967 году (издательство «YMCA-Press», Париж).\r\n В СССР книжный вариант без купюр увидел свет в 1973 году (издательство «Художественная литература», тираж 30 000 экземпляров). \r\nПроизведение неоднократно экранизировано и инсценировано.",
                            Isbn = "978-5-04-102789-1",
                            PageCount = 1130,
                            PublishDate = new DateTime(1966, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Мастер и Маргарита"
                        },
                        new
                        {
                            BookId = 5,
                            CoverImgPath = "Assets/Images/Books/The%20death%20of%20Ivan%20Ilyich.jpeg",
                            Description = "Повесть Л. Н. Толстого, над которой он работал с 1882 по 1886 год, внПовесть широко признана одной из вершин мировой литературы[1] и величайшим свершением Толстого в области малой литературной формы.Входит во Всемирную библиотеку(серия книг Норвежского книжного клуба)",
                            Isbn = "978-5-699-15152-2",
                            PageCount = 543,
                            PublishDate = new DateTime(1886, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Смерть Ивана Ильича"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<int>("BookingStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("BooksLibraryId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingId");

                    b.HasIndex("BooksLibraryId");

                    b.HasIndex("ClientId");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            BookingStatus = 2,
                            BooksLibraryId = 1,
                            ClientId = 1,
                            Code = 88889,
                            FinishDate = new DateTime(2023, 3, 5, 21, 13, 44, 556, DateTimeKind.Local).AddTicks(4418),
                            StartDate = new DateTime(2023, 2, 26, 21, 13, 44, 556, DateTimeKind.Local).AddTicks(4400)
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

                    b.Property<int>("Count")
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
                            Count = 2,
                            LibraryId = 1
                        },
                        new
                        {
                            BooksLibrariesId = 2,
                            BookId = 2,
                            Count = 3,
                            LibraryId = 1
                        },
                        new
                        {
                            BooksLibrariesId = 3,
                            BookId = 3,
                            Count = 1,
                            LibraryId = 1
                        },
                        new
                        {
                            BooksLibrariesId = 4,
                            BookId = 4,
                            Count = 2,
                            LibraryId = 1
                        },
                        new
                        {
                            BooksLibrariesId = 5,
                            BookId = 2,
                            Count = 2,
                            LibraryId = 2
                        },
                        new
                        {
                            BooksLibrariesId = 6,
                            BookId = 1,
                            Count = 3,
                            LibraryId = 2
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Email = "test@test.com",
                            Name = "Артур",
                            PhoneNumber = "+375299999999",
                            Surname = "Пирожков"
                        },
                        new
                        {
                            ClientId = 2,
                            Email = "tes2t@com.by",
                            Name = "Артур",
                            PhoneNumber = "+37529у9999999",
                            Surname = "Пирожков"
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
                            Type = "Роман"
                        },
                        new
                        {
                            GenreId = 5,
                            Type = "Рассказ"
                        },
                        new
                        {
                            GenreId = 6,
                            Type = "Детектив"
                        });
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.ImagesForCarousel", b =>
                {
                    b.Property<int>("ImagesForCarouselId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImagesForCarouselId"));

                    b.Property<string>("CoverImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImagesForCarouselId");

                    b.HasIndex("LibraryId");

                    b.ToTable("ImagesForCarousel");

                    b.HasData(
                        new
                        {
                            ImagesForCarouselId = 1,
                            CoverImgPath = "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-1.jpg",
                            LibraryId = 1
                        },
                        new
                        {
                            ImagesForCarouselId = 2,
                            CoverImgPath = "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-2.jpg",
                            LibraryId = 1
                        },
                        new
                        {
                            ImagesForCarouselId = 3,
                            CoverImgPath = "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-3.jpg",
                            LibraryId = 1
                        },
                        new
                        {
                            ImagesForCarouselId = 4,
                            CoverImgPath = "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg",
                            LibraryId = 2
                        },
                        new
                        {
                            ImagesForCarouselId = 5,
                            CoverImgPath = "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-2.jpg",
                            LibraryId = 2
                        },
                        new
                        {
                            ImagesForCarouselId = 6,
                            CoverImgPath = "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg",
                            LibraryId = 2
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

                    b.Property<string>("CoverImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorPhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HistoryOfLibrary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShortDiscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibraryId")
                        .HasName("PK__Library__A136475FA23EBF26");

                    b.ToTable("Library", (string)null);

                    b.HasData(
                        new
                        {
                            LibraryId = 1,
                            Address = "просп.Независимости, 11б",
                            AgeGroup = "Нет ограничений ",
                            CoverImgPath = "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg",
                            DirectorPhotoLink = "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg",
                            Email = "www.nlb.by",
                            HistoryOfLibrary = "Национальная библиотека Беларуси (НББ) была основана постановлением Совета народных комиссаров БССР в 1922 году как Белорусская государственная и университетская библиотека Белорусского государственного университета (БГУ). На момент открытия фонды библиотеки насчитывали всего 60 тысяч экземпляров, которыми пользовались 1,1 тысячи человек. Первым собственным зданием библиотеки стал Юбилейный дом на Захарьевской улице (ныне — проспект Независимости). Постановлением СНК БССР от 14 мая 1926 году библиотека была выведена из состава БГУ и реорганизована в Белорусскую государственную библиотеку. В 1932 году библиотеке было присвоено имя В. И. Ленина. В тот же год библиотека получила новое здание архитектора Г. Лаврова в конструктивистском стиле. ",
                            MapLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
                            Name = "Национальная библиотека Минска",
                            PhoneNumber = "+375 17 368-37-37",
                            ShortDiscription = "Национальная библиотека Беларуси (НББ)"
                        },
                        new
                        {
                            LibraryId = 2,
                            Address = "Улица Веры Хоружей 16",
                            AgeGroup = "Нет ограничений",
                            CoverImgPath = "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg",
                            DirectorPhotoLink = "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg",
                            Email = "www.publib.by/",
                            HistoryOfLibrary = "Сёння Цэнтральная бібліятэка імя Янкі Купалы – гэта: ТРАДЫЦЫЯ БЫЦЬ ПАТРЭБНАЙ",
                            MapLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
                            Name = "Библиотека им. Янки Купалы",
                            PhoneNumber = "8 017 242-21-15",
                            ShortDiscription = "Цэнтральная бібліятэка імя Янкі Купалы"
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

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Booking", b =>
                {
                    b.HasOne("LibraryAggregator.DataLayer.Entities.BooksLibrary", "BooksLibrary")
                        .WithMany("Booking")
                        .HasForeignKey("BooksLibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAggregator.DataLayer.Entities.Client", "Client")
                        .WithMany("Booking")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BooksLibrary");

                    b.Navigation("Client");
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

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.ImagesForCarousel", b =>
                {
                    b.HasOne("LibraryAggregator.DataLayer.Entities.Library", "Library")
                        .WithMany("ImagesForCarousel")
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

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.BooksLibrary", b =>
                {
                    b.Navigation("Booking");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Client", b =>
                {
                    b.Navigation("Booking");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Genre", b =>
                {
                    b.Navigation("BooksGenres");
                });

            modelBuilder.Entity("LibraryAggregator.DataLayer.Entities.Library", b =>
                {
                    b.Navigation("BooksLibraries");

                    b.Navigation("ImagesForCarousel");

                    b.Navigation("OperatingModes");
                });
#pragma warning restore 612, 618
        }
    }
}

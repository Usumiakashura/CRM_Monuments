using DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class DBInitializer
    {
        //public static void InitData(EFDBContext context)
        //{
        //    List<Contract> _contracts;
        //    //List<StoneMaterial> _stoneMaterials;

        //    List<TypeText> _typeTexts;
        //    List<TypePortrait> _typePortraits;
        //    List<MedallionMaterial> _medallionMaterials;
        //    List<ShapeMedallion> _shapeMedallions;

        //    if (!context.TypeTexts.Any())
        //    {
        //        _typeTexts = new List<TypeText>()
        //        {
        //            new TypeText()
        //            {
        //                Name = "Углубленный"
        //            },
        //            new TypeText()
        //            {
        //                Name = "Литье"
        //            },
        //            new TypeText()
        //            {
        //                Name = "Caggiatti"
        //            },
        //            new TypeText()
        //            {
        //                Name = "На табличке"
        //            },
        //            new TypeText()
        //            {
        //                Name = "На медальоне"
        //            },
        //            new TypeText()
        //            {
        //                Name = "Станочный"
        //            },
        //            new TypeText()
        //            {
        //                Name = "Фрейзерный"
        //            }
        //        };
        //        context.TypeTexts.AddRange(_typeTexts);
        //        context.SaveChanges();
        //    }
        //    if (!context.TypePortraits.Any())
        //    {
        //        _typePortraits = new List<TypePortrait>()
        //        {
        //            new TypePortrait()
        //            {
        //                Name = "Ручной"
        //            },
        //            new TypePortrait()
        //            {
        //                Name = "Станочный"
        //            }
        //        };
        //        context.TypePortraits.AddRange(_typePortraits);
        //        context.SaveChanges();
        //    }
        //    if (!context.MedallionMaterials.Any())
        //    {
        //        _medallionMaterials = new List<MedallionMaterial>()
        //        {
        //            new MedallionMaterial()
        //            {
        //                Name = "Керамогранит"
        //            },
        //            new MedallionMaterial()
        //            {
        //                Name = "Керамика (фарфор)"
        //            },
        //            new MedallionMaterial()
        //            {
        //                Name = "Триплекс"
        //            },
        //            new MedallionMaterial()
        //            {
        //                Name = "Однослойное стекло"
        //            },
        //            new MedallionMaterial()
        //            {
        //                Name = "Металлокерамика"
        //            },
        //            new MedallionMaterial()
        //            {
        //                Name = "Табличка из нерж.стали"
        //            }
        //        };
        //        context.MedallionMaterials.AddRange(_medallionMaterials);
        //        context.SaveChanges();
        //    }
        //    if (!context.ShapeMedallions.Any())
        //    {
        //        _shapeMedallions = new List<ShapeMedallion>()
        //        {
        //            new ShapeMedallion()
        //            {
        //                Name = "Овальная"
        //            },
        //            new ShapeMedallion()
        //            {
        //                Name = "Прямоугольная"
        //            },
        //            new ShapeMedallion()
        //            {
        //                Name = "Арка"
        //            }
        //        };
        //        context.ShapeMedallions.AddRange(_shapeMedallions);
        //        context.SaveChanges();
        //    }

        //    if (!context.Contracts.Any())
        //    {
        //        _contracts = new List<Contract>()
        //        {
        //            new Contract()
        //            {
        //                DateOfConclusion = new DateTime(2022, 01, 03),
        //                NumYear = "22",
        //                Place = "ДО",
        //                Number = "1",
        //                InstallmentPayment = false,
        //                Customers = new List<Customer>()
        //                {
        //                    new Customer()
        //                    {
        //                        FirstName = "Иван",
        //                        LastName = "Провельев",
        //                        Email = "ivan123@gmail.com",
        //                        Number = "+375291658923",
        //                        Viber = true,
        //                        Telegram = false,
        //                        WhatsApp = false,
        //                        Address = "какой-то адрес (обязателен для заполнения)"
        //                    },
        //                    new Customer()
        //                    {
        //                        FirstName = "Петр",
        //                        LastName = "Провельев",
        //                        Email = "ivan123@gmail.com",
        //                        Number = "+375297568896",
        //                        Viber = true,
        //                        Telegram = true,
        //                        WhatsApp = true,
        //                        Address = "какой-то адрес (обязателен для заполнения)"
        //                    }
        //                },
        //                Pickup = false,
        //                BurialAddress = "Плещеницы",
        //                Row = 2,
        //                BurialPlace = 13,
        //                Sector = 3,
        //                Grave = 7,
        //                DistanceFromMKAD = 125,
        //                NumberOfTrips = 1,
        //                DeadLine = new DateTime(2022, 04, 01),
        //                Stellas = new List<Stella>()
        //                {
        //                    new Stella()
        //                    {
        //                        Deceaseds = new List<Deceased>()
        //                        {
        //                            new Deceased()
        //                            {
        //                                TextOnStella = new TextOnStella()
        //                                {
        //                                    LastName = "Иванов",
        //                                    FirstName = "Петр",
        //                                    MiddleName = "Владимирович",
        //                                    DateBirthday = new DateTime(1956, 07, 19),
        //                                    DateRip = new DateTime(2020, 03, 03),
        //                                    TypeText = context.TypeTexts.Find(4),
        //                                    EngraverName = "Василий"
        //                                },

        //                                Photo = true,
        //                                PhotosOnMonument = new List<PhotoOnMonument>()
        //                                {
        //                                    new Medallion()
        //                                    {
        //                                        MedallionMaterial = context.MedallionMaterials.Find(4),
        //                                        SizeMedallion = "15*15",
        //                                        ShapeMedallion = context.ShapeMedallions.Find(3),
        //                                        BackgroundMedallion = "Серый",
        //                                        Frame = true,
        //                                        TypeFrame = "Ф1",
        //                                        SizeFrame = "16*16",
        //                                        ShapeFrame = "круг",
        //                                        ColorFrame = "серый"
        //                                    }
        //                                },
        //                                Epitaphs = new List<Epitaph>()
        //                                {
        //                                    new Epitaph()
        //                                }
        //                            }
        //                        }
        //                    }
        //                },
        //                Decoration = "оформления нет",
        //                NoteInstaller = "какие-то примечания для установщика",
        //                NoteProduction = "какие-то примечания по производству",
        //                Note = "какие-то примечания ко всему заказу"
        //            },//1
        //            new Contract()
        //            {
        //                DateOfConclusion = new DateTime(2022, 01, 07),
        //                NumYear = "22",
        //                Place = "ДО",
        //                Number = "2",
        //                InstallmentPayment = false,
        //                Customers = new List<Customer>()
        //                {
        //                    new Customer()
        //                    {
        //                        FirstName = "Петр",
        //                        LastName = "Песков",
        //                        Email = "yyyyy123@gmail.com",
        //                        Number = "+375293561123",
        //                        Viber = true,
        //                        Telegram = true,
        //                        WhatsApp = false,
        //                        Address = "какой-то адрес (обязателен для заполнения)"
        //                    }
        //                },
        //                Pickup = false,
        //                BurialAddress = "Могилев",
        //                Row = 5,
        //                BurialPlace = 3,
        //                Sector = 5,
        //                Grave = 3,
        //                DistanceFromMKAD = 260,
        //                NumberOfTrips = 1,
        //                DeadLine = new DateTime(2022, 04, 03),
        //                Stellas = new List<Stella>()
        //                {
        //                    new Stella()
        //                    {
        //                        Deceaseds = new List<Deceased>()
        //                        {
        //                            new Deceased()
        //                            {
        //                                TextOnStella = new TextOnStella()
        //                                {
        //                                    LastName = "Песков",
        //                                    FirstName = "Марк",
        //                                    MiddleName = "Владимирович",
        //                                    DateBirthday = new DateTime(1968, 11, 01),
        //                                    DateRip = new DateTime(2021, 10, 18),
        //                                    TypeText = context.TypeTexts.Find(2),
        //                                    EngraverName = "Василий"
        //                                },
                                        
        //                                Photo = true,
        //                                PhotosOnMonument = new List<PhotoOnMonument>()
        //                                {
        //                                    new Portrait()
        //                                    {
        //                                        TypePortrait = context.TypePortraits.Find(1),
        //                                        //TypePortraitName = context.TypePortraits.Find(1).Name,
        //                                        Artist = "Татьяна"
        //                                    }
        //                                },
        //                                Epitaphs = new List<Epitaph>()
        //                                {
        //                                    new Epitaph()
        //                                    {
        //                                        TypeText = context.TypeTexts.Find(4),
        //                                        NotesTextEpitaph = "какие-то примечания к эпитафии",
        //                                        EngraverEpitaph = "Василий"
        //                                    }
        //                                }
        //                            }
        //                        },
        //                    }
        //                },
                        
        //                Decoration = "какие-нибудь пометки по оформлению",
        //                NoteInstaller = "какие-то примечания для установщика",
        //                NoteProduction = "какие-то примечания по производству",
        //                Note = "какие-то примечания ко всему заказу"
        //            },//2
        //            new Contract()
        //            {
        //                DateOfConclusion = new DateTime(2022, 01, 10),
        //                NumYear = "22",
        //                Place = "ДО",
        //                Number = "3",
        //                InstallmentPayment = true,
        //                Customers = new List<Customer>()
        //                {
        //                    new Customer()
        //                    {
        //                        FirstName = "Вячеслав",
        //                        Email = "dzxtck123@gmail.com",
        //                        Number = "+375296521423",
        //                        Viber = false,
        //                        Telegram = true,
        //                        WhatsApp = false,
        //                        Address = "какой-то адрес (обязателен для заполнения)"
        //                    }
        //                },
        //                Pickup = false,
        //                BurialAddress = "Мачулищи",
        //                Row = 2,
        //                BurialPlace = 13,
        //                Sector = 3,
        //                Grave = 7,
        //                DistanceFromMKAD = 125,
        //                NumberOfTrips = 1,
        //                DeadLine = new DateTime(2022, 04, 08),
        //                Stellas = new List<Stella>()
        //                {
        //                    new Stella()
        //                    {
        //                        Deceaseds = new List<Deceased>()
        //                        {
        //                            new Deceased()
        //                            {
        //                                TextOnStella = new TextOnStella()
        //                                {
        //                                    LastName = "Самойлов",
        //                                    FirstName = "Константин",
        //                                    MiddleName = "Владимирович",
        //                                    DateBirthday = new DateTime(1956, 07, 19),
        //                                    DateRip = new DateTime(2020, 03, 03),
        //                                    TypeText = context.TypeTexts.Find(4),
        //                                    EngraverName = "Василий"
        //                                },
                                        
        //                                Photo = true,
        //                                PhotosOnMonument = new List<PhotoOnMonument>()
        //                                {
        //                                    new Medallion()
        //                                    {
        //                                        MedallionMaterial = context.MedallionMaterials.Find(2),
        //                                        SizeMedallion = "15*15",
        //                                        ShapeMedallion = context.ShapeMedallions.Find(2),
        //                                        BackgroundMedallion = "Серый",
        //                                        Frame = true,
        //                                        TypeFrame = "Ф1",
        //                                        SizeFrame = "16*16",
        //                                        ShapeFrame = "круг",
        //                                        ColorFrame = "серый"
        //                                    }
        //                                },
        //                                Epitaphs = new List<Epitaph>()
        //                                {
        //                                    new Epitaph()
        //                                }
        //                            }
        //                        },
        //                    }
        //                },
                        
        //                Decoration = "оформления нет",
        //                NoteInstaller = "какие-то примечания для установщика",
        //                NoteProduction = "какие-то примечания по производству",
        //                Note = "какие-то примечания ко всему заказу"
        //            },//3
        //            new Contract()
        //            {
        //                DateOfConclusion = new DateTime(2022, 01, 11),
        //                NumYear = "22",
        //                Place = "ДО",
        //                Number = "4",
        //                InstallmentPayment = false,
        //                Customers = new List<Customer>()
        //                {
        //                    new Customer()
        //                    {
        //                        FirstName = "Петр",
        //                        LastName = "Песков",
        //                        Email = "yyyyy123@gmail.com",
        //                        Number = "+375293561123",
        //                        Viber = true,
        //                        Telegram = true,
        //                        WhatsApp = false,
        //                        Address = "какой-то адрес (обязателен для заполнения)"
        //                    }
        //                },
        //                Pickup = false,
        //                BurialAddress = "какой-то адрес",
        //                Row = 5,
        //                BurialPlace = 3,
        //                Sector = 5,
        //                Grave = 3,
        //                DistanceFromMKAD = 260,
        //                NumberOfTrips = 1,
        //                DeadLine = new DateTime(2022, 04, 03),
        //                Stellas = new List<Stella>()
        //                {
        //                    new Stella()
        //                    {
        //                        Deceaseds = new List<Deceased>()
        //                        {
        //                            new Deceased()
        //                            {
        //                                TextOnStella = new TextOnStella()
        //                                {
        //                                    LastName = "Песков",
        //                                    FirstName = "Марк",
        //                                    MiddleName = "Владимирович",
        //                                    DateBirthday = new DateTime(1968, 11, 01),
        //                                    DateRip = new DateTime(2021, 10, 18),
        //                                    TypeText = context.TypeTexts.Find(3),
        //                                    EngraverName = "Василий"
        //                                },
                                        
        //                                Photo = true,
        //                                PhotosOnMonument = new List<PhotoOnMonument>()
        //                                {
        //                                    new Portrait()
        //                                    {
        //                                        TypePortrait = context.TypePortraits.Find(1),
        //                                        //TypePortraitName = context.TypePortraits.Find(1).Name,
        //                                        Artist = "Татьяна"
        //                                    }
        //                                },
        //                                Epitaphs = new List<Epitaph>()
        //                                {
        //                                    new Epitaph()
        //                                    {
        //                                        TypeText = context.TypeTexts.Find(1),
        //                                        NotesTextEpitaph = "какие-то примечания к эпитафии",
        //                                        EngraverEpitaph = "Василий"
        //                                    }
        //                                }
        //                            }
        //                        },
        //                    }
        //                },
                        
        //                Decoration = "какие-нибудь пометки по оформлению",
        //                NoteInstaller = "какие-то примечания для установщика",
        //                NoteProduction = "какие-то примечания по производству",
        //                Note = "какие-то примечания ко всему заказу"
        //            }//4
        //        };
        //        context.Contracts.AddRange(_contracts);
        //        context.SaveChanges();
        //    }

        //}

        public static async Task Seed(EFDBContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            // создать БД, если она еще не создана
            context.Database.EnsureCreated();
            // проверка наличия ролей
            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                // создать роль manager
                await roleManager.CreateAsync(roleAdmin);
                var roleUserManager = new IdentityRole
                {
                    Name = "manager",
                    NormalizedName = "manager"
                };
                // создать роль manager
                await roleManager.CreateAsync(roleUserManager);
                var roleArtist = new IdentityRole
                {
                    Name = "artist",
                    NormalizedName = "artist"
                };
                // создать роль artist
                await roleManager.CreateAsync(roleArtist);
                var roleEngraver = new IdentityRole
                {
                    Name = "engraver",
                    NormalizedName = "engraver"
                };
                // создать роль engraver
                await roleManager.CreateAsync(roleEngraver);
            }

            // проверка наличия пользователей
            if (!context.Users.Any())
            {
                // создать пользователя admin@mail.ru
                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru",
                    Name = "Администратор"
                };
                await userManager.CreateAsync(admin, "123456");
                // создать пользователя margarita@mail.ru
                var manager = new ApplicationUser
                {
                    Email = "margarita@mail.ru",
                    UserName = "margarita@mail.ru",
                    Name = "Маргарита"
                };
                await userManager.CreateAsync(manager, "123456");
                // создать пользователя vlad@mail.ru
                var artist1 = new ApplicationUser
                {
                    Email = "vlad@mail.ru",
                    UserName = "vlad@mail.ru",
                    Name = "Владимир"
                };
                await userManager.CreateAsync(artist1, "123456");
                // создать пользователя tanya@mail.ru
                var artist2 = new ApplicationUser
                {
                    Email = "tanya@mail.ru",
                    UserName = "tanya@mail.ru",
                    Name = "Татьяна"
                };
                await userManager.CreateAsync(artist2, "123456");
                // создать пользователя maksim@mail.ru
                var engraver = new ApplicationUser
                {
                    Email = "maksim@mail.ru",
                    UserName = "maksim@mail.ru",
                    Name = "Максим"
                };
                await userManager.CreateAsync(engraver, "123456");
                // назначить роли
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
                manager = await userManager.FindByEmailAsync("margarita@mail.ru");
                await userManager.AddToRoleAsync(manager, "manager");
                artist1 = await userManager.FindByEmailAsync("vlad@mail.ru");
                await userManager.AddToRoleAsync(artist1, "artist");
                artist2 = await userManager.FindByEmailAsync("tanya@mail.ru");
                await userManager.AddToRoleAsync(artist2, "artist");
                engraver = await userManager.FindByEmailAsync("maksim@mail.ru");
                await userManager.AddToRoleAsync(engraver, "engraver");
            }

            List<Contract> _contracts;
            List<TypeText> _typeTexts;
            List<TypePortrait> _typePortraits;
            List<MedallionMaterial> _medallionMaterials;
            List<ShapeMedallion> _shapeMedallions;
            List<MedallionSize> _medallionSizes;

            if (!context.TypeTexts.Any())
            {
                _typeTexts = new List<TypeText>()
                {
                    new TypeText()
                    {
                        Name = "Углубленный"
                    },
                    new TypeText()
                    {
                        Name = "Литье"
                    },
                    new TypeText()
                    {
                        Name = "Caggiatti"
                    },
                    new TypeText()
                    {
                        Name = "На табличке"
                    },
                    new TypeText()
                    {
                        Name = "На медальоне"
                    },
                    new TypeText()
                    {
                        Name = "Станочный"
                    },
                    new TypeText()
                    {
                        Name = "Фрейзерный"
                    }
                };
                context.TypeTexts.AddRange(_typeTexts);
                context.SaveChanges();
            }
            if (!context.TypePortraits.Any())
            {
                _typePortraits = new List<TypePortrait>()
                {
                    new TypePortrait()
                    {
                        Name = "Ручной"
                    },
                    new TypePortrait()
                    {
                        Name = "Станочный"
                    }
                };
                context.TypePortraits.AddRange(_typePortraits);
                context.SaveChanges();
            }
            if (!context.MedallionMaterials.Any())
            {
                _medallionMaterials = new List<MedallionMaterial>()
                {
                    new MedallionMaterial()
                    {
                        Name = "Фарфор"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Керамика"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Металлокерамика"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Керамогранит"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Стекло"
                    }
                };
                context.MedallionMaterials.AddRange(_medallionMaterials);
                context.SaveChanges();
            }
            if (!context.ShapeMedallions.Any())
            {
                _shapeMedallions = new List<ShapeMedallion>()
                {
                    new ShapeMedallion()
                    {
                        Name = "Овальная",
                        MedallionMaterials = new List<MedallionMaterial>()
                        {
                            context.MedallionMaterials.Find(1),
                            context.MedallionMaterials.Find(2),
                            context.MedallionMaterials.Find(3),
                            context.MedallionMaterials.Find(4),
                            context.MedallionMaterials.Find(5)
                        }
                    },
                    new ShapeMedallion()
                    {
                        Name = "Прямоугольная",
                        MedallionMaterials = new List<MedallionMaterial>()
                        {
                            context.MedallionMaterials.Find(1),
                            context.MedallionMaterials.Find(2),
                            context.MedallionMaterials.Find(3),
                            context.MedallionMaterials.Find(4),
                            context.MedallionMaterials.Find(5)
                        }
                    },
                    new ShapeMedallion()
                    {
                        Name = "Арка",
                        MedallionMaterials = new List<MedallionMaterial>()
                        {
                            context.MedallionMaterials.Find(4),
                            context.MedallionMaterials.Find(5)
                        }
                    }
                };
                context.ShapeMedallions.AddRange(_shapeMedallions);
                context.SaveChanges();
            }
            if (!context.MedallionSizes.Any())
            {
                _medallionSizes = new List<MedallionSize>()
                {
                    new MedallionSize()
                    {
                        Size = "9x12"
                    },
                    new MedallionSize()
                    {
                        Size = "11x15"
                    },
                    new MedallionSize()
                    {
                        Size = "13x18"
                    },
                    new MedallionSize()
                    {
                        Size = "17x23"
                    },
                    new MedallionSize()
                    {
                        Size = "18x24"
                    },
                    new MedallionSize()
                    {
                        Size = "20x30"
                    },
                    new MedallionSize()
                    {
                        Size = "24x30"
                    },
                    new MedallionSize()
                    {
                        Size = "30x40"
                    },
                    new MedallionSize()
                    {
                        Size = "40x60"
                    }
                };
                context.MedallionSizes.AddRange(_medallionSizes);
                context.SaveChanges();
            }



            if (!context.Contracts.Any())
            {
                _contracts = new List<Contract>()
                {
                    new Contract()
                    {
                        DateOfConclusion = new DateTime(2022, 01, 03),
                        NumYear = "22",
                        Place = "ДО",
                        Number = "1",
                        InstallmentPayment = false,
                        Customers = new List<Customer>()
                        {
                            new Customer()
                            {
                                FirstName = "Иван",
                                LastName = "Провельев",
                                Email = "ivan123@gmail.com",
                                Number = "+375291658923",
                                Viber = true,
                                Telegram = false,
                                WhatsApp = false,
                                Address = "какой-то адрес (обязателен для заполнения)"
                            },
                            new Customer()
                            {
                                FirstName = "Петр",
                                LastName = "Провельев",
                                Email = "ivan123@gmail.com",
                                Number = "+375297568896",
                                Viber = true,
                                Telegram = true,
                                WhatsApp = true,
                                Address = "какой-то адрес (обязателен для заполнения)"
                            }
                        },
                        Pickup = false,
                        BurialAddress = "Плещеницы",
                        Row = 2,
                        BurialPlace = 13,
                        Sector = 3,
                        Grave = 7,
                        DistanceFromMKAD = 125,
                        NumberOfTrips = 1,
                        DeadLine = new DateTime(2022, 04, 01),
                        Stellas = new List<Stella>()
                        {
                            new Stella()
                            {
                                Deceaseds = new List<Deceased>()
                                {
                                    new Deceased()
                                    {
                                        TextOnStella = new TextOnStella()
                                        {
                                            LastName = "Иванов",
                                            FirstName = "Петр",
                                            MiddleName = "Владимирович",
                                            DateBirthday = new DateTime(1956, 07, 19),
                                            DateRip = new DateTime(2020, 03, 03),
                                            TypeText = context.TypeTexts.Find(4),
                                            EngraverName = "Василий"
                                        },

                                        Photo = true,
                                        PhotosOnMonument = new List<PhotoOnMonument>()
                                        {
                                            new Medallion()
                                            {
                                                MedallionMaterial = context.MedallionMaterials.Find(4),
                                                SizeMedallion = "15*15",
                                                ShapeMedallion = context.ShapeMedallions.Find(3),
                                                BackgroundMedallion = "Серый",
                                                Frame = true,
                                                TypeFrame = "Ф1",
                                                SizeFrame = "16*16",
                                                ShapeFrame = "круг",
                                                ColorFrame = "серый"
                                            }
                                        },
                                        Epitaphs = new List<Epitaph>()
                                        {
                                            new Epitaph()
                                        }
                                    }
                                }
                            }
                        },
                        Decoration = "оформления нет",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Note = "какие-то примечания ко всему заказу"
                    },//1
                    new Contract()
                    {
                        DateOfConclusion = new DateTime(2022, 01, 07),
                        NumYear = "22",
                        Place = "ДО",
                        Number = "2",
                        InstallmentPayment = false,
                        Customers = new List<Customer>()
                        {
                            new Customer()
                            {
                                FirstName = "Петр",
                                LastName = "Песков",
                                Email = "yyyyy123@gmail.com",
                                Number = "+375293561123",
                                Viber = true,
                                Telegram = true,
                                WhatsApp = false,
                                Address = "какой-то адрес (обязателен для заполнения)"
                            }
                        },
                        Pickup = false,
                        BurialAddress = "Могилев",
                        Row = 5,
                        BurialPlace = 3,
                        Sector = 5,
                        Grave = 3,
                        DistanceFromMKAD = 260,
                        NumberOfTrips = 1,
                        DeadLine = new DateTime(2022, 04, 03),
                        Stellas = new List<Stella>()
                        {
                            new Stella()
                            {
                                Deceaseds = new List<Deceased>()
                                {
                                    new Deceased()
                                    {
                                        TextOnStella = new TextOnStella()
                                        {
                                            LastName = "Песков",
                                            FirstName = "Марк",
                                            MiddleName = "Владимирович",
                                            DateBirthday = new DateTime(1968, 11, 01),
                                            DateRip = new DateTime(2021, 10, 18),
                                            TypeText = context.TypeTexts.Find(2),
                                            EngraverName = "Василий"
                                        },

                                        Photo = true,
                                        PhotosOnMonument = new List<PhotoOnMonument>()
                                        {
                                            new Portrait()
                                            {
                                                TypePortrait = context.TypePortraits.Find(1),
                                                //TypePortraitName = context.TypePortraits.Find(1).Name,
                                                Artist = "Татьяна"
                                            }
                                        },
                                        Epitaphs = new List<Epitaph>()
                                        {
                                            new Epitaph()
                                            {
                                                TypeText = context.TypeTexts.Find(4),
                                                NotesTextEpitaph = "какие-то примечания к эпитафии",
                                                EngraverEpitaph = "Василий"
                                            }
                                        }
                                    }
                                },
                            }
                        },

                        Decoration = "какие-нибудь пометки по оформлению",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Note = "какие-то примечания ко всему заказу"
                    },//2
                    new Contract()
                    {
                        DateOfConclusion = new DateTime(2022, 01, 10),
                        NumYear = "22",
                        Place = "ДО",
                        Number = "3",
                        InstallmentPayment = true,
                        Customers = new List<Customer>()
                        {
                            new Customer()
                            {
                                FirstName = "Вячеслав",
                                Email = "dzxtck123@gmail.com",
                                Number = "+375296521423",
                                Viber = false,
                                Telegram = true,
                                WhatsApp = false,
                                Address = "какой-то адрес (обязателен для заполнения)"
                            }
                        },
                        Pickup = false,
                        BurialAddress = "Мачулищи",
                        Row = 2,
                        BurialPlace = 13,
                        Sector = 3,
                        Grave = 7,
                        DistanceFromMKAD = 125,
                        NumberOfTrips = 1,
                        DeadLine = new DateTime(2022, 04, 08),
                        Stellas = new List<Stella>()
                        {
                            new Stella()
                            {
                                Deceaseds = new List<Deceased>()
                                {
                                    new Deceased()
                                    {
                                        TextOnStella = new TextOnStella()
                                        {
                                            LastName = "Самойлов",
                                            FirstName = "Константин",
                                            MiddleName = "Владимирович",
                                            DateBirthday = new DateTime(1956, 07, 19),
                                            DateRip = new DateTime(2020, 03, 03),
                                            TypeText = context.TypeTexts.Find(4),
                                            EngraverName = "Василий"
                                        },

                                        Photo = true,
                                        PhotosOnMonument = new List<PhotoOnMonument>()
                                        {
                                            new Medallion()
                                            {
                                                MedallionMaterial = context.MedallionMaterials.Find(2),
                                                SizeMedallion = "15*15",
                                                ShapeMedallion = context.ShapeMedallions.Find(2),
                                                BackgroundMedallion = "Серый",
                                                Frame = true,
                                                TypeFrame = "Ф1",
                                                SizeFrame = "16*16",
                                                ShapeFrame = "круг",
                                                ColorFrame = "серый"
                                            }
                                        },
                                        Epitaphs = new List<Epitaph>()
                                        {
                                            new Epitaph()
                                        }
                                    }
                                },
                            }
                        },

                        Decoration = "оформления нет",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Note = "какие-то примечания ко всему заказу"
                    },//3
                    new Contract()
                    {
                        DateOfConclusion = new DateTime(2022, 01, 11),
                        NumYear = "22",
                        Place = "ДО",
                        Number = "4",
                        InstallmentPayment = false,
                        Customers = new List<Customer>()
                        {
                            new Customer()
                            {
                                FirstName = "Петр",
                                LastName = "Песков",
                                Email = "yyyyy123@gmail.com",
                                Number = "+375293561123",
                                Viber = true,
                                Telegram = true,
                                WhatsApp = false,
                                Address = "какой-то адрес (обязателен для заполнения)"
                            }
                        },
                        Pickup = false,
                        BurialAddress = "какой-то адрес",
                        Row = 5,
                        BurialPlace = 3,
                        Sector = 5,
                        Grave = 3,
                        DistanceFromMKAD = 260,
                        NumberOfTrips = 1,
                        DeadLine = new DateTime(2022, 04, 03),
                        Stellas = new List<Stella>()
                        {
                            new Stella()
                            {
                                Deceaseds = new List<Deceased>()
                                {
                                    new Deceased()
                                    {
                                        TextOnStella = new TextOnStella()
                                        {
                                            LastName = "Песков",
                                            FirstName = "Марк",
                                            MiddleName = "Владимирович",
                                            DateBirthday = new DateTime(1968, 11, 01),
                                            DateRip = new DateTime(2021, 10, 18),
                                            TypeText = context.TypeTexts.Find(3),
                                            EngraverName = "Василий"
                                        },

                                        Photo = true,
                                        PhotosOnMonument = new List<PhotoOnMonument>()
                                        {
                                            new Portrait()
                                            {
                                                TypePortrait = context.TypePortraits.Find(1),
                                                //TypePortraitName = context.TypePortraits.Find(1).Name,
                                                Artist = "Татьяна"
                                            }
                                        },
                                        Epitaphs = new List<Epitaph>()
                                        {
                                            new Epitaph()
                                            {
                                                TypeText = context.TypeTexts.Find(1),
                                                NotesTextEpitaph = "какие-то примечания к эпитафии",
                                                EngraverEpitaph = "Василий"
                                            }
                                        }
                                    }
                                },
                            }
                        },

                        Decoration = "какие-нибудь пометки по оформлению",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Note = "какие-то примечания ко всему заказу"
                    }//4
                };
                context.Contracts.AddRange(_contracts);
                context.SaveChanges();
            }


        }

    }
}

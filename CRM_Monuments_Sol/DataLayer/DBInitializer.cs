using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBInitializer
    {
        public static void InitData(EFDBContext context)
        {
            List<Contract> _contracts;
            List<StoneMaterial> _stoneMaterials;

            List<TypeText> _typeTexts;
            List<TypePortrait> _typePortraits;
            List<MedallionMaterial> _medallionMaterials;
            List<ShapeMedallion> _shapeMedallions;
            List<ColorMedallion> _colorMedallions;

            if (!context.StoneMaterials.Any())
            {
                _stoneMaterials = new List<StoneMaterial>()
                {
                    new StoneMaterial()
                    {
                        Name = "ГабброДиабаз"
                    },
                    new StoneMaterial()
                    {
                        Name = "Елизовский"
                    },
                    new StoneMaterial()
                    {
                        Name = "Мансуровский"
                    },
                    new StoneMaterial()
                    {
                        Name = "Покостовский"
                    },
                    new StoneMaterial()
                    {
                        Name = "Гранатовый Амфиболит"
                    },
                    new StoneMaterial()
                    {
                        Name = "Капустянский"
                    },
                    new StoneMaterial()
                    {
                        Name = "Масловский"
                    },
                    new StoneMaterial()
                    {
                        Name = "Нью Империал Ред"
                    },
                    new StoneMaterial()
                    {
                        Name = "Санди Грей"
                    },
                    new StoneMaterial()
                    {
                        Name = "Санди Роуз"
                    },
                    new StoneMaterial()
                    {
                        Name = "Новоданиловский"
                    },
                    new StoneMaterial()
                    {
                        Name = "Онега"
                    },
                    new StoneMaterial()
                    {
                        Name = "Балморал Красный"
                    },
                    new StoneMaterial()
                    {
                        Name = "Балтик Грин"
                    },
                    new StoneMaterial()
                    {
                        Name = "Куру Грей"
                    },
                    new StoneMaterial()
                    {
                        Name = "Лезник"
                    },
                    new StoneMaterial()
                    {
                        Name = "Шанси Блэк"
                    },
                    new StoneMaterial()
                    {
                        Name = "Аврора"
                    },
                    new StoneMaterial()
                    {
                        Name = "Амадеус"
                    },
                    new StoneMaterial()
                    {
                        Name = "Сюськюянсаари"
                    },
                    new StoneMaterial()
                    {
                        Name = "Блю Перл Голубой"
                    },
                    new StoneMaterial()
                    {
                        Name = "Лабродорит"
                    }
                };
                context.StoneMaterials.AddRange(_stoneMaterials);
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
                                Email = "ivan123@gmail.com",
                                Number = "+375291658923",
                                Viber = true,
                                Telegram = false,
                                WhatsApp = false,
                                Address = "какой-то адрес (обязателен для заполнения)"
                            }
                        },
                        Pickup = false,
                        BurialAddress = "какой-то адрес",
                        Row = 2,
                        BurialPlace = 13,
                        Sector = 3,
                        Grave = 7,
                        DistanceFromMKAD = 125,
                        NumberOfTrips = 1,
                        DeadLine = new DateTime(2022, 04, 01),
                        Deceaseds = new List<Deceased>()
                        {
                            new Deceased()
                            {
                                LastName = "Иванов",
                                FirstName = "Петр",
                                MiddleName = "Владимирович",
                                DateBirthday = new DateTime(1956, 07, 19),
                                DateRip = new DateTime(2020, 03, 03),
                                Photo = true,
                                PhotosOnMonument = new List<PhotoOnMonument>()
                                {
                                    new Medallion()
                                    {
                                        MaterialMedallion = "Стекло",
                                        SizeMedallion = "15*15",
                                        ShapeMedallion = "круг",
                                        ColorMedallion = "Белый",
                                        BackgroundMedallion = "Серый",
                                        Frame = true,
                                        TypeFrame = "Ф1",
                                        SizeFrame = "16*16",
                                        ShapeFrame = "круг",
                                        ColorFrame = "серый"
                                    }
                                },
                                TypeNameText = "гравировка",
                                EngraverName = "Василий",
                                Epitaph = false
                            }
                        },
                        Decoration = "оформления нет",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Accessories = new List<Accessorie>()
                        {
                            new StoneAccessorie()
                            {
                                Name = "стела",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 150,
                                Width = 100,
                                Thickness = 5,
                                Note = "Форма А17"
                            },
                            new StoneAccessorie()
                            {
                                Name = "подставка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 50,
                                Width = 20,
                                Thickness = 15
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 2,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 100,
                                Thickness = 5
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 50,
                                Thickness = 5
                            },
                            new StoneAccessorie()
                            {
                                Name = "фигурная накладка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 50,
                                Width = 30,
                                Thickness = 2,
                                Note = "Прямоугольная"
                            },
                            new StoneAccessorie()
                            {
                                Name = "надгробка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 100,
                                Width = 50,
                                Thickness = 5,
                                Note = "Прямоугольник"
                            }
                        },
                        Note = "какие-то примечания ко всему заказу"
                    },//1
                    new Contract()
                    {
                        DateOfConclusion = new DateTime(2022, 01, 03),
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
                        BurialAddress = "какой-то адрес",
                        Row = 5,
                        BurialPlace = 3,
                        Sector = 5,
                        Grave = 3,
                        DistanceFromMKAD = 260,
                        NumberOfTrips = 1,
                        DeadLine = new DateTime(2022, 04, 03),
                        Deceaseds = new List<Deceased>()
                        {
                            new Deceased()
                            {
                                LastName = "Песков",
                                FirstName = "Марк",
                                MiddleName = "Владимирович",
                                DateBirthday = new DateTime(1968, 11, 01),
                                DateRip = new DateTime(2021, 10, 18),
                                Photo = true,
                                PhotosOnMonument = new List<PhotoOnMonument>()
                                {
                                    new Portrait()
                                    {
                                        TypePortrait = "ручной",
                                        Artist = "Татьяна"
                                    }
                                },
                                TypeNameText = "гравировка",
                                EngraverName = "Василий",
                                Epitaph = true,
                                TypeNameEpitaph = "гравировка",
                                NotesTextEpitaph = "какие-то примечания к эпитафии",
                                EngraverEpitaph = "Василий"
                            }
                        },
                        Decoration = "какие-нибудь пометки по оформлению",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Accessories = new List<Accessorie>()
                        {
                            new StoneAccessorie()
                            {
                                Name = "стела",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 150,
                                Width = 100,
                                Thickness = 5,
                                Note = "Форма А17"
                            },
                            new StoneAccessorie()
                            {
                                Name = "подставка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 50,
                                Width = 20,
                                Thickness = 15
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 2,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 100,
                                Thickness = 5
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 50,
                                Thickness = 5
                            }
                        },
                        Note = "какие-то примечания ко всему заказу"
                    },//2
                    new Contract()
                    {
                        DateOfConclusion = new DateTime(2022, 01, 03),
                        NumYear = "22",
                        Place = "ДО",
                        Number = "3",
                        InstallmentPayment = false,
                        Customers = new List<Customer>()
                        {
                            new Customer()
                            {
                                FirstName = "Иван",
                                Email = "ivan123@gmail.com",
                                Number = "+375291658923",
                                Viber = true,
                                Telegram = false,
                                WhatsApp = false,
                                Address = "какой-то адрес (обязателен для заполнения)"
                            }
                        },
                        Pickup = false,
                        BurialAddress = "какой-то адрес",
                        Row = 2,
                        BurialPlace = 13,
                        Sector = 3,
                        Grave = 7,
                        DistanceFromMKAD = 125,
                        NumberOfTrips = 1,
                        DeadLine = new DateTime(2022, 04, 01),
                        Deceaseds = new List<Deceased>()
                        {
                            new Deceased()
                            {
                                LastName = "Иванов",
                                FirstName = "Петр",
                                MiddleName = "Владимирович",
                                DateBirthday = new DateTime(1956, 07, 19),
                                DateRip = new DateTime(2020, 03, 03),
                                Photo = true,
                                PhotosOnMonument = new List<PhotoOnMonument>()
                                {
                                    new Medallion()
                                    {
                                        MaterialMedallion = "Стекло",
                                        SizeMedallion = "15*15",
                                        ShapeMedallion = "круг",
                                        ColorMedallion = "Белый",
                                        BackgroundMedallion = "Серый",
                                        Frame = true,
                                        TypeFrame = "Ф1",
                                        SizeFrame = "16*16",
                                        ShapeFrame = "круг",
                                        ColorFrame = "серый"
                                    }
                                },
                                TypeNameText = "гравировка",
                                EngraverName = "Василий",
                                Epitaph = false
                            }
                        },
                        Decoration = "оформления нет",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Accessories = new List<Accessorie>()
                        {
                            new StoneAccessorie()
                            {
                                Name = "стела",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 150,
                                Width = 100,
                                Thickness = 5,
                                Note = "Форма А17"
                            },
                            new StoneAccessorie()
                            {
                                Name = "подставка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 50,
                                Width = 20,
                                Thickness = 15
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 2,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 100,
                                Thickness = 5
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 50,
                                Thickness = 5
                            },
                            new StoneAccessorie()
                            {
                                Name = "фигурная накладка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 50,
                                Width = 30,
                                Thickness = 2,
                                Note = "Прямоугольная"
                            },
                            new StoneAccessorie()
                            {
                                Name = "надгробка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 100,
                                Width = 50,
                                Thickness = 5,
                                Note = "Прямоугольник"
                            }
                        },
                        Note = "какие-то примечания ко всему заказу"
                    },//3
                    new Contract()
                    {
                        DateOfConclusion = new DateTime(2022, 01, 03),
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
                        Deceaseds = new List<Deceased>()
                        {
                            new Deceased()
                            {
                                LastName = "Песков",
                                FirstName = "Марк",
                                MiddleName = "Владимирович",
                                DateBirthday = new DateTime(1968, 11, 01),
                                DateRip = new DateTime(2021, 10, 18),
                                Photo = true,
                                PhotosOnMonument = new List<PhotoOnMonument>()
                                {
                                    new Portrait()
                                    {
                                        TypePortrait = "ручной",
                                        Artist = "Татьяна"
                                    }
                                },
                                TypeNameText = "гравировка",
                                EngraverName = "Василий",
                                Epitaph = true,
                                TypeNameEpitaph = "гравировка",
                                NotesTextEpitaph = "какие-то примечания к эпитафии",
                                EngraverEpitaph = "Василий"
                            }
                        },
                        Decoration = "какие-нибудь пометки по оформлению",
                        NoteInstaller = "какие-то примечания для установщика",
                        NoteProduction = "какие-то примечания по производству",
                        Accessories = new List<Accessorie>()
                        {
                            new StoneAccessorie()
                            {
                                Name = "стела",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 150,
                                Width = 100,
                                Thickness = 5,
                                Note = "Форма А17"
                            },
                            new StoneAccessorie()
                            {
                                Name = "подставка",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 50,
                                Width = 20,
                                Thickness = 15
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 2,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 100,
                                Thickness = 5
                            },
                            new StoneAccessorie()
                            {
                                Name = "цветник",
                                Number = 1,
                                Material = context.StoneMaterials.Find(7),
                                StoneId = context.StoneMaterials.Find(7).Id,
                                Height = 8,
                                Width = 50,
                                Thickness = 5
                            }
                        },
                        Note = "какие-то примечания ко всему заказу"
                    }//4
                };
                context.Contracts.AddRange(_contracts);
                context.SaveChanges();
            }

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
                        Name = "Керамогранит"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Керамика (фарфор)"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Триплекс"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Однослойное стекло"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Металлокерамика"
                    },
                    new MedallionMaterial()
                    {
                        Name = "Табличка из нерж.стали"
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
                        Name = "Овальная"
                    },
                    new ShapeMedallion()
                    {
                        Name = "Прямоугольная"
                    },
                    new ShapeMedallion()
                    {
                        Name = "Арка"
                    }
                };
                context.ShapeMedallions.AddRange(_shapeMedallions);
                context.SaveChanges();
            }
            if (!context.ColorMedallions.Any())
            {
                _colorMedallions = new List<ColorMedallion>()
                {
                    new ColorMedallion()
                    {
                        Name = "Цветной"
                    },
                    new ColorMedallion()
                    {
                        Name = "Черно-белый"
                    }
                };
                context.ColorMedallions.AddRange(_colorMedallions);
                context.SaveChanges();
            }

        }
    }
}

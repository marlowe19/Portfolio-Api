
using System.Collections.Generic;
using Marlowe.Antonius.Models;

namespace Marlowe.Antonius
{
    public  class CvService
    {
        public PersoonlijkeGegevens PersoonlijkeGegevens()
        {
            return new PersoonlijkeGegevens
            {
                Naam = "Marlowe",
                Achternaam = "Antonius",
                Emailadres = "marlowe.antonius@gmail.com",
                Telefoonnummer = "0641619644",
                Website = "www.marlowe.nl",
                Bescrhrijving = "beschrijving van wie ik ben"
            };
        }

        public Werkervaring GetWerkervaring()
        {
            return new Werkervaring
            {
                Titel = "Werkervaring",

                ErvaringsLijst = new List<Ervaring>
                {
                    new Ervaring
                    {
                        Bedrijfsnaam = "Incentro",
                        Datum = "01-09-2013-heden",
                        Projecten = new List<Project>
                        {
                            new Project
                            {
                                Titel = "Migratie Traject Tridion/ Project management",
                                Bedrijf = "De Nederlansche bank",
                                Rol = "Scrum master, developer, project leider"
                            },
                            new Project
                            {
                                Titel ="C# development" ,
                                Bedrijf = "Rabobank international",
                            },
                            new Project
                            {
                                Titel= "Nieuwe mvc website bouwen",
                                Bedrijf = "DAF",
                                Rol = ".net mvc developer/ scrum master",
                            },
                            new Project
                            {
                                Titel = "Nieuwe vacture website maken voor PostNL",
                                Bedrijf = "PostNL",
                                Rol = ".Net MVC developer/ javascript developer"
                            },
                            new Project
                            {
                                Titel = "Ontwikkelen van een nieuwe Upload Portal voor Achema",
                                Bedrijf = "Impress",
                                Rol = ".Net MVC developer",
                                Technieken = new []{"C#","javascript","ASP.Net MVC"}
                            },
                            new Project
                            {
                                Titel = "Ontwikkelen nieuwe corporate website voor DNV-GL",
                                Bedrijf = "DNV-GL Noorwegen",
                                Rol = "Full stack developer",
                                Technieken = new []{"C#","ASP.Net MVC","javascript"}
                            },
                            new Project{
                                Titel = "Ontwikkelen kennisbank voor call center medewerkers",
                                Bedrijf = "ING",
                                Rol = "Full stack developer/ Tridion developer",
                                Technieken = new []{"C#","ASP.Net MVC", "javascript"}
                            },
                            new Project
                            {
                                Titel = "Ontwikkelen interim, website voor DNV-GL",
                                Bedrijf = "DNV-GL Noorwegen",
                                Rol = "Frontend developer",
                                Technieken = new []{"Html","Css","javascript"}
                            }

                        }
                    }
                }
            };
        }

        public IEnumerable<Opleiding> GetOpleidingen()
        {
            return new List<Opleiding>
            {
                new Opleiding
                {
                    Naam = "Communicatie en Media",
                    Diploma = "Bachlor Communicatie",
                    Instantie = "Inholland"
                },
                new Opleiding
                {
                    Naam = "IT-Webmaster",
                    Diploma = "IT-webmaster",
                    Instantie = "Grafisch Lyceum"
                }
            };
        }

    }
}

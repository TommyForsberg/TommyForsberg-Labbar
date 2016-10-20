using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljettbokning
{
    class EventHandler
    {
        public List<Film> Films { get; set; }
        public List<Festival> Festivals {get; set; }
        public List <Concert> Concerts { get; set; }
        public List <Person> Bookings { get; set; }

        public EventHandler()
        {

            Bookings = new List<Person>()
            { new Person {FirstName = "Tommy", LastName = "Forsberg",
                MyEvents = new List<Event>
                { new Festival { DateOfEvent = new DateTime(2017, 01, 02, 21, 00, 0), City = "Göteborg", Venue = "Ullevi", FestivalTitle = "Summer Burst" },
              new Festival { DateOfEvent = new DateTime(2017, 01, 11, 21, 00, 0), City = "Stockholm", Venue = "Globen", FestivalTitle = "Techno Festival" }
            }
            }, new Person {FirstName = "Sara", LastName = "Larsson",
                MyEvents = new List<Event>
                { new Film { DateOfEvent = new DateTime(2016, 10, 27), City = "Stockholm", Venue = "Filmstaden", FilmTitle = "Nosferatu", Director = "Werner Herzog"}
                } }  
            };
            Films = new List<Film>
            {
                new Film { DateOfEvent = new DateTime(2016, 10, 27), City = "Stockholm", Venue = "Filmstaden", FilmTitle = "Nosferatu", Director = "Werner Herzog"},
                new Film {DateOfEvent = new DateTime(2016, 11, 27), City = "Stockholm", Venue = "Spegeln", FilmTitle = "Die Hardest", Director = "Brian Fury"}
            };

            Festivals = new List<Festival>()
            {
                new Festival {DateOfEvent = new DateTime( 2017, 01, 02,21,00,0), City = "Göteborg", Venue = "Ullevi", FestivalTitle = "Summer Burst" },
                new Festival {DateOfEvent = new DateTime( 2017, 08, 02), City = "Borlänge", Venue = "City Centre", FestivalTitle = "Peace & Love" }
            };

            Concerts = new List<Concert>()
            {
                new Concert {DateOfEvent = new DateTime( 2016, 11, 10), City = "Sandviken", Venue = "Göranssons Arena", Artist = "50 Cent" },
                new Concert {DateOfEvent = new DateTime( 2016, 12, 02), City = "Gävle", Venue = "Läkerol Arena", Artist = "Tomas Ledin" },

            };
        }
        public void MyBookings()
        {
            Person singlePerson = Bookings.SingleOrDefault(person => String.Equals(person.ToString(), Runtime.CurrentUser));
            if (singlePerson != null)
            {
                if (singlePerson.MyEvents.Count == 0)
                {
                    Console.WriteLine("You have no bookings");
                }

                else

                    foreach (var Event in singlePerson.MyEvents)
                    {
                        Console.WriteLine(EventCaster(Event));
                        Console.WriteLine();

                    }
                Console.ReadLine();
            }
        }
        public void ListOrBook()
        {
            List<Event> availableEvents = new List<Event>();
            availableEvents.AddRange(Festivals);
            availableEvents.AddRange(Films);
            availableEvents.AddRange(Concerts);

            int index = 0;
            foreach (var Event in availableEvents)
            {
                index++;
                Console.WriteLine("EventNo"+ index +": "+ EventCaster(Event));
                Console.WriteLine();
            }
            Console.WriteLine("Do you want to make a reservation? (Yes/No)");
            string input = Console.ReadLine().ToLower();
            if (input == "yes" || input =="y" )
            {
                Console.WriteLine("What event do you wanna book? Input EventNo:");
                int booking = int.Parse(Console.ReadLine());
                Person singlePerson = Bookings.SingleOrDefault(person => String.Equals(person.ToString(), Runtime.CurrentUser));
                if (singlePerson != null)
                    singlePerson.MyEvents.Add(availableEvents[index - 1]);
            }
        }
        public string EventCaster(Event tempEvent)
        {
            string firstString = "Venue: " + tempEvent.Venue + " City: "+ tempEvent.City;
            if (tempEvent is Film)
            {
                Film newFilm = (Film)tempEvent;
                return String.Format("Film: {0}" + " | " + newFilm.DateOfEvent + "\n" +firstString + " Director: {1}",newFilm.FilmTitle, newFilm.Director );
            }

            if (tempEvent is Festival)
            {
                Festival newFestival = (Festival)tempEvent;
                string temp = newFestival.FestivalTitle;
                return String.Format("Festival: " + temp +" | " + tempEvent.DateOfEvent + "\n" + firstString);
            }

            if (tempEvent is Concert)
            {
                Concert newConcert = (Concert)tempEvent;
                string temp = newConcert.Artist;
                return String.Format("Concert: {0}" + " | " + newConcert.DateOfEvent + "\n" + firstString, newConcert.Artist);

            }
            return String.Format("NIX");
        }
        }
    }

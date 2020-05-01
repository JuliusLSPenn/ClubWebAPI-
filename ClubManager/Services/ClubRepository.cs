using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubManager.Models;

namespace ClubManager.Services
{
    public class ClubRepository
    {
        public IList<Club> GetAllClubs()
        {
            IList<Club> clubs = new List<Club>();

            clubs.Add
            (
                  new Club
                  {
                      Name = "The Scorpio",
                      StreetAddress = "2301 Freedom Dr",
                      City = "Charlotte",
                      State = "NC",
                      ZipCode = "28208",
                      Phone = "(704) 373-9124",
                      ContactName = "Manager Name",
                      ImageURL = "TBD URL Image string"
                  }
            );

           clubs.Add
           (
                 new Club
                 {
                     Name = "Vibrations Night Lounge",
                     StreetAddress = "5237 Albemarle Rd",
                     City = "Charlotte",
                     State = "NC",
                     ZipCode = "28212",
                     Phone = "(704) 537-3323",
                     ContactName = "Manager Name",
                     ImageURL = "TBD URL Image string"
                 }
           );

           clubs.Add
           (
                 new Club
                 {
                     Name = "Club One",
                     StreetAddress = "950 Nc Music Factory Blvd",
                     City = "Charlotte",
                     State = "NC",
                     ZipCode = "28202",
                     Phone = "(704) 496-9972",
                     ContactName = "Manager Name",
                     ImageURL = "TBD URL Image string"
                 }
           );

            return clubs;
        }

        public IList<Club> GetClubsByState(string state)
        {
            IList<Club> clubs = new List<Club>();

            clubs.Add
            (
                  new Club
                  {
                      Name = "The Scorpio",
                      StreetAddress = "2301 Freedom Dr",
                      City = "Athens",
                      State = "GA",
                      ZipCode = "28208",
                      Phone = "(704) 373-9124",
                      ContactName = "Manager Name",
                      ImageURL = "TBD URL Image string"
                  }
            );

            clubs.Add
            (
                  new Club
                  {
                      Name = "Vibrations Night Lounge",
                      StreetAddress = "5237 Albemarle Rd",
                      City = "Columbia",
                      State = "SC",
                      ZipCode = "28212",
                      Phone = "(704) 537-3323",
                      ContactName = "Manager Name",
                      ImageURL = "TBD URL Image string"
                  }
            );

            clubs.Add
            (
                  new Club
                  {
                      Name = "Club One",
                      StreetAddress = "950 Nc Music Factory Blvd",
                      City = "Charlotte",
                      State = "NC",
                      ZipCode = "28202",
                      Phone = "(704) 496-9972",
                      ContactName = "Manager Name",
                      ImageURL = "TBD URL Image string"
                  }
            );

            return clubs.Where(x => x.State == state).ToList();
        }

        public IList<Club> GetClubsByCityState(string city, string state)
        {
            IList<Club> clubs = new List<Club>();

            clubs.Add
            (
                  new Club
                  {
                      Name = "The Scorpio",
                      StreetAddress = "2301 Freedom Dr",
                      City = "Charlotte",
                      State = "NC",
                      ZipCode = "28208",
                      Phone = "(704) 373-9124",
                      ContactName = "Manager Name",
                      ImageURL = "TBD URL Image string"
                  }
            );

            clubs.Add
            (
                  new Club
                  {
                      Name = "Vibrations Night Lounge",
                      StreetAddress = "5237 Albemarle Rd",
                      City = "Charlotte",
                      State = "NC",
                      ZipCode = "28212",
                      Phone = "(704) 537-3323",
                      ContactName = "Manager Name",
                      ImageURL = "TBD URL Image string"
                  }
            );

            clubs.Add
            (
                  new Club
                  {
                      Name = "Club One",
                      StreetAddress = "950 Nc Music Factory Blvd",
                      City = "Charlotte",
                      State = "NC",
                      ZipCode = "28202",
                      Phone = "(704) 496-9972",
                      ContactName = "Manager Name",
                      ImageURL = "TBD URL Image string"
                  }
            );

            return clubs.Where(x => x.City == city && x.State == state).ToList();

        }
    }
}
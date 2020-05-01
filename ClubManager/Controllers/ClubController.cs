using ClubManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClubManager.Services;

namespace ClubManager.Controllers
{
    public class ClubController : ApiController
    {
        private ClubRepository clubRepository;

        public ClubController()
        {
            this.clubRepository = new ClubRepository();
        }

        public IList<Club> GetAllClubs()
        {
            return this.clubRepository.GetAllClubs();
        }

        public IList<Club> GetClubsByCityState(string city, string state)
        {
            return this.clubRepository.GetClubsByCityState(city, state);
        }

        public IList<Club> GetClubsByState(string state)
        {
            return this.clubRepository.GetClubsByState(state);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class EntriesController : ApiController
    {
        private EntriesRepository _entriesRepository = null;

        public EntriesController(EntriesRepository entriesRepository)
        {
            _entriesRepository = entriesRepository;
        }

        public IEnumerable<Entry> Get()
        {
            var activityBiking = new Activity() { Name = "Biking" };

            return new List<Entry>()
            {
                new Entry(2017, 1, 2, activityBiking, 10.0m),
                new Entry(2017, 1, 3, activityBiking, 12.2m)
            };
        }

        public Entry Get(int id)
        {
            return null;
        }

        public void Post(Entry entry)
        {

        }

        public void Put(int id, Entry entry)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
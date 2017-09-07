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

        public IHttpActionResult Get()
        {
            return Ok(_entriesRepository.GetList());
        }

        public IHttpActionResult Get(int id)
        {
            var entry = _entriesRepository.Get(id);

            if (entry == null)
            {
                return NotFound();
            }

            return Ok(entry);
        }

        public IHttpActionResult Post(Entry entry)
        {
            _entriesRepository.Add(entry);

            return Created(
                Url.Link("DefaultApi", new { controller = "Entries", id = entry.Id }),
                entry);
        }

        public void Put(int id, Entry entry)
        {
            _entriesRepository.Update(entry);
        }

        public void Delete(int id)
        {
            _entriesRepository.Delete(id);
        }
    }
}
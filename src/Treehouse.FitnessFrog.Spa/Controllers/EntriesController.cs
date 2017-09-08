using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;
using Treehouse.FitnessFrog.Spa.Dto;

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

        public IHttpActionResult Post(EntryDto entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entryModel = entry.ToModel();

            _entriesRepository.Add(entryModel);

            entry.Id = entryModel.Id;

            return Created(
                Url.Link("DefaultApi", new { controller = "Entries", id = entry.Id }),
                entry);
        }

        public IHttpActionResult Put(int id, EntryDto entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _entriesRepository.Update(entry.ToModel());

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        public void Delete(int id)
        {
            _entriesRepository.Delete(id);
        }
    }
}
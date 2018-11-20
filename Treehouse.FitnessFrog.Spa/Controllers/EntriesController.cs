using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;
using Treehouse.FitnessFrog.Spa.DTO;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class EntriesController : ApiController
    {
        private EntriesRepository _entriesRepository;

        public EntriesController(EntriesRepository entriesRepository)
        {
            _entriesRepository = entriesRepository;
        }

        public Entry GetEntry(int id)
        {
            return _entriesRepository.Get(id, false);
        }

        public IHttpActionResult GetEntries()
        {
            return Ok(_entriesRepository.GetList());
        }

        public IHttpActionResult Post(EntryDto entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entryModel = entry.ToModel();
            _entriesRepository.Add(entryModel);
            return Created(
                Url.Link("DefaultApi", new { controller = "Entries", id = entry.Id }), entry);
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

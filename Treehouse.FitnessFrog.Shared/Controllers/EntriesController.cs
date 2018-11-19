using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Shared.Controllers
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
            return null;
        }

        public IHttpActionResult GetEntries()
        {
            return Ok(_entriesRepository.GetList());
        }

        public IHttpActionResult Post(Entry entry)
        {
            _entriesRepository.Add(entry);
            return Created(
                Url.Link("DefaultApi", new { controller = "Entries", id = entry.Id }), entry);
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

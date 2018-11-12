using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Shared.Controllers
{
    public class EntriesController : ApiController
    {
        public Entry GetEntries(int id)
        {
            return null;
        }

        public IEnumerable<Entry> GetEntry()
        {
            var activityBiking = new Activity()
            {
                Name = "Biking"
            };
            return new List<Entry>()
            {
                new Entry(2017, 1, 2, activityBiking, 10.0m),
                new Entry(2017, 1, 3, activityBiking, 12.2m)
            };
        }

        public void Post()
        {

        }

        public void Put()
        {

        }

        public void Delete()
        {

        }
    }
}

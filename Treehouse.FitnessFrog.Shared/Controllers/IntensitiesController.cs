﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Shared.Controllers
{
    public class IntensitiesController : ApiController
    {
        public IHttpActionResult Get()
        {
            var results = Enum.GetValues(typeof(Entry.IntensityLevel))
                .Cast<Entry.IntensityLevel>()
                .Select(il => new { id = (int)il, name = il.ToString() })
                .ToList();

            return Ok(results);
        }
    }
}

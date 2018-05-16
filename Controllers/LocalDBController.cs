using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using XHealthAng5.Data;

namespace XHealthAng5.Controllers
{
    [Produces("application/json")]
    //[Route("api/LocalDB")]
    public class LocalDBController : Controller
    {
        private readonly HealthCareContext _context;
        //private ExportStrategy _exportStrategy;

        //public void SetExportStrategy(ExportStrategy exportstrategy, HealthCareContext _context)
        //{
        //    this._exportStrategy = exportstrategy;
        //}

        public LocalDBController(HealthCareContext context)
        {
            _context = context;
        }

        // GET: api/LocalDB
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET: api/LocalDB/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // GET: api/LocalDB/Initialize
        [HttpGet]
        [Route("api/LocalDB/Initialize")]
        public void Initialize()
        { 
            DbInitializer.Initialize(_context);
        }

        // POST: api/LocalDB
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/LocalDB/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMastery.Models;
using ApiMastery.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMastery.Controllers
{
    [Route("api/series")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private IRepository<Series> SeriesRepo;

        public SeriesController(IRepository<Series> SeriesRepo)
        {
            this.SeriesRepo = SeriesRepo;
        }

        // GET api/Seriess
        [HttpGet]
        public IEnumerable<Series> Get()
        {
            return SeriesRepo.GetAll();
        }

        // GET api/Seriess/5
        [HttpGet("{id}")]
        public Series Get(int id)
        {
            return SeriesRepo.GetById(id);
        }

        // POST api/Seriess
        [HttpPost]
        public IEnumerable<Series> Post([FromBody] Series Series)
        {
            SeriesRepo.Create(Series);
            return SeriesRepo.GetAll();
        }

        // PUT api/Seriess/5
        [HttpPut("{id}")]
        public IEnumerable<Series> Put([FromBody] Series Series)
        {
            SeriesRepo.Update(Series);
            return SeriesRepo.GetAll();
        }

        // DELETE api/Seriess/5
        [HttpDelete("{id}")]
        public IEnumerable<Series> Delete(int id)
        {
            var Series = SeriesRepo.GetById(id);
            SeriesRepo.Delete(Series);
            return SeriesRepo.GetAll();
        }
    }
}
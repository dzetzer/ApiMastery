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
    [Route("api/games")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IRepository<Game> GameRepo;

        public GameController(IRepository<Game> GameRepo)
        {
            this.GameRepo = GameRepo;
        }

        // GET api/Games
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return GameRepo.GetAll();
        }

        // GET api/Games/5
        [HttpGet("{id}")]
        public Game Get(int id)
        {
            return GameRepo.GetById(id);
        }

        // POST api/Games
        [HttpPost]
        public IEnumerable<Game> Post([FromBody] Game Game)
        {
            GameRepo.Create(Game);
            return GameRepo.GetAll();
        }

        // PUT api/Games/5
        [HttpPut("{id}")]
        public IEnumerable<Game> Put([FromBody] Game Game)
        {
            GameRepo.Update(Game);
            return GameRepo.GetAll();
        }

        // DELETE api/Games/5
        [HttpDelete("{id}")]
        public IEnumerable<Game> Delete(int id)
        {
            var Game = GameRepo.GetById(id);
            GameRepo.Delete(Game);
            return GameRepo.GetAll();
        }
    }
}
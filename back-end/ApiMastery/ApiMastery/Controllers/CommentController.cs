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
    [Route("api/comments")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private IRepository<Comment> CommentRepo;

        public CommentController(IRepository<Comment> CommentRepo)
        {
            this.CommentRepo = CommentRepo;
        }

        // GET api/Comments
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return CommentRepo.GetAll();
        }

        // GET api/Comments/5
        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return CommentRepo.GetById(id);
        }

        // POST api/Comments
        [HttpPost]
        public IEnumerable<Comment> Post([FromBody] Comment Comment)
        {
            CommentRepo.Create(Comment);
            return CommentRepo.GetAll();
        }

        // PUT api/Comments/5
        [HttpPut("{id}")]
        public IEnumerable<Comment> Put([FromBody] Comment Comment)
        {
            CommentRepo.Update(Comment);
            return CommentRepo.GetAll();
        }

        // DELETE api/Comments/5
        [HttpDelete("{id}")]
        public IEnumerable<Comment> Delete(int id)
        {
            var Comment = CommentRepo.GetById(id);
            CommentRepo.Delete(Comment);
            return CommentRepo.GetAll();
        }
    }
}
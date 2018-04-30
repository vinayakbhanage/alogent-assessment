using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlogentBoard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlogentBoard.API.Controllers
{
    [Produces("application/json")]
    //[Route("api/Postits")]
    public class PostitsController : Controller
    {
        // GET: api/Postits
        [HttpGet]
        [Route("api/boards/{boardId}/post-its")]
        public IEnumerable<Postits> Get(int boardId)
        {
            return AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == boardId).Postits;
        }

        // GET: api/Postits/5
        [HttpGet]
        [Route("api/boards/{boardId}/post-its/{postId}")]
        public Postits Get(int boardId, int postId)
        {
            return AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == boardId).Postits.First(p => p.Id == postId);
        }

        // POST: api/Postits
        [HttpPost]
        [Route("api/boards/{boardId}/post-its")]
        public void Post([FromRoute]int boardId, [FromBody]Postits postIt)
        {
            Board ExistingBoard = AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == boardId);

            postIt.Id = (ExistingBoard.Postits.Count == 0) ? 1 : (from l in ExistingBoard.Postits select l.Id).Max() + 1;  //ExistingBoard.Postits + 1;
            postIt.Date = DateTime.Now;

            ExistingBoard.Postits.Add(postIt);
        }

        // PUT: api/Postits/5
        [HttpPut]
        [Route("api/boards/{boardId}/post-its/{postId}")]
        public void Put(int boardId, int postId, [FromBody]Postits postIt)
        {
            Postits ExistingPostit = AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == boardId).Postits.First(p => p.Id == postId);

            ExistingPostit.Title = postIt.Title;
            ExistingPostit.Note = postIt.Note;
            ExistingPostit.Date = DateTime.Now;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("api/boards/{boardId}/post-its/{postId}")]
        public void Delete(int boardId, int postId)
        {
            Postits ExistingPostit = AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == boardId).Postits.First(p => p.Id == postId);

           AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == boardId).Postits.Remove(ExistingPostit);
           
        }
    }
}

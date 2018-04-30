using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlogentBoard.API.AppData;
using AlogentBoard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlogentBoard.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Boards")]
    public class BoardsController : Controller
    {
        // GET: api/Boards
        [HttpGet]
        public IEnumerable<Board> Get()
        {
            return AlogentBoard.API.AppData.AlogentBoard.AlogentBoards;
        }

        // GET: api/Boards/5
        [HttpGet("{id}", Name = "Get")]
        public Board Get(int id)
        {
            return AlogentBoard.API.AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == id);
        }

        // POST: api/Boards
        [HttpPost]
        public void Post([FromBody]Board board)
        {
            int NewBoardId = AlogentBoard.API.AppData.AlogentBoard.AlogentBoards.Count() + 1;

            board.Id = NewBoardId;
            board.Date = DateTime.Now;
            board.Postits = new List<Postits>();

            AlogentBoard.API.AppData.AlogentBoard.AlogentBoards.Add(board);
        }

        // PUT: api/Boards/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Board board)
        {
            Board ExistingBoard = AlogentBoard.API.AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == id);
            ExistingBoard.Name = board.Name;
            ExistingBoard.Date = DateTime.Now;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Board ExistingBoard = AlogentBoard.API.AppData.AlogentBoard.AlogentBoards.Find(b => b.Id == id);
            AlogentBoard.API.AppData.AlogentBoard.AlogentBoards.Remove(ExistingBoard);
        }
    }
}

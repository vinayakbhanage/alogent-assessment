using AlogentBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlogentBoard.API.AppData
{
    public class AlogentBoard
    {
        public static List<Board> AlogentBoards = new List<Board>()
        {
            new Board() {
                Id = 1,
                Name = "Alogent Assessment Board",
                Date = new DateTime(2018, 4, 28),
                Postits =
                    new List<Postits>()
                    {
                        new Postits{
                            Id = 1,
                            Date = new DateTime(2018, 4, 28),
                            Note = "The following application is a system that allows users to post small notes on their boards. For this exercise, added and removed data needs to only last as long as the web host is online.",
                            Title = "Test description"
                        },
                        new Postits
                        {
                            Id = 2,
                            Date = new DateTime(2018, 4, 29),
                            Note = "Git,C#,ASP.NET Core Web API,Angular 5,Bootstrap,NUnit,Moq",
                            Title = "Tech Stack"
                        }
                    }
            },
            new Board() {
                Id = 2,
                Name = "Vinayak's Board",
                Date = new DateTime(2018, 4, 29),
                Postits =
                    new List<Postits>()
                    {
                        new Postits{
                            Id = 3,
                            Date = new DateTime(2018, 4, 29),
                            Note = "New description",
                            Title = "Note 1"
                        },
                        new Postits
                        {
                            Id = 4,
                            Date = new DateTime(2018, 4, 29),
                            Note = "Namisha is driving us crazy...",
                            Title = "Namisha"
                        }
                    }
            }
        };

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGamesList.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsCompleted { get; set; }


    }
}
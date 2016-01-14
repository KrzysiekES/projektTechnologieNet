using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
namespace ProjektTechnologieNet.Models
{
    public class Club
    {
        public Club()
        {
            this.Players = new List<Player>();

        }

        public int clubID { get; set; }
        public string name { get; set; }
        public int capacity { get; set; }
        public string couch { get; set; }
        public string city { get; set; }
        public string league { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }

    public class Player
    {
        public Player() { }

        public int playerID { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string position { get; set; }
        public string nationality { get; set; }
        public int age { get; set; }
        public int clubID { get; set; }

        public virtual Club Club { get; set; }

    }
    public class MyDBContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }

        //public System.Data.Entity.DbSet<ProjektTechnologieNet.Models.Club> AllClubs { get; set; }
    }
}
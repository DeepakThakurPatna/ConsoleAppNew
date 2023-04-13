using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace ConsoleApp.Models
{
    public class ConsoleModel
    {
        public int SongId { get; set; }
        public int SongSrNo { get; set; }
        public string SongName { get; set; }
        public string SongDescription { get; set; }
        public string ArtistName { get; set; }
        public string SearchTerm { get; set; }
        
    }
}

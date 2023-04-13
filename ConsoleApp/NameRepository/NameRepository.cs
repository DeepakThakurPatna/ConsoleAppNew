using ConsoleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.ConsoleRepository
{
    public class NameRepository
    {
        public List<ConsoleModel> GetAllSong()
        {
            return DataSource();
        }
        public ConsoleModel GetById(int id)
        {
            return DataSource().Where(x => x.SongId == id).FirstOrDefault();
        }
        public List<ConsoleModel> SearchByName(string songname)
        {
            if (string.IsNullOrEmpty(songname))
            {
                return DataSource(); 
            }
            return DataSource().Where(x => x.SongName.Contains(songname) || x.SongDescription.Contains(songname)).ToList();
        }
        private List<ConsoleModel> DataSource()
        {
            return new List<ConsoleModel>()
            { 
                new ConsoleModel (){SongId = 1,SongSrNo=1, SongName = "Aanand Manaye aao", SongDescription = "Aanand Manaye aao", ArtistName = "Ramesh"},
                new ConsoleModel (){SongId = 2,SongSrNo=2, SongName = "Param Pita ki", SongDescription = "Param Pita ki", ArtistName = "Ramesh"},
                new ConsoleModel (){SongId=3 ,SongSrNo=3,SongName="Prabhu ka dhanyawad karunga" , SongDescription="Prabhu ka Dhanyawad", ArtistName="Rohit"}
            };
        }
        
    }
}

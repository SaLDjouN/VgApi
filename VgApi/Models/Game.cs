using VgApi.Models;

namespace VgApi.Models
{
    public class Game
    {

        public string Titre { get; set; }
        public int Release_Yr { get; set; }
        public int Rating { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }

    }
}

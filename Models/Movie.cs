namespace Move.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set;  }
        public string Synopsis { get; set; }
        public string Year { get; set;  }
        public int Duration { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Rating { get; set; }
    }
}
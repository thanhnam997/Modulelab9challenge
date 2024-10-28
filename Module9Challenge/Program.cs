
namespace VideoGames
{
    public class VideoGames
    {
        public required string Name { get; set; }
        public required string Genre { get; set; }
        public double Rating { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //  Create a list of VideoGame objects
            List<VideoGame> games = new List<VideoGame>
            {
                new VideoGame { Name = "Sonic", Genre = "Platform", Rating = 4.3 },
                new VideoGame { Name = "Tetris", Genre = "Puzzle", Rating = 3.9 },
                new VideoGame { Name = "Sudoku", Genre = "Puzzle", Rating = 4.0 },
                new VideoGame { Name = "Snake", Genre = "Arcade", Rating = 4.1 },
                new VideoGame { Name = "Mario", Genre = "Platform", Rating = 4.5 }
            };

            //  Filter games with a rating of 4 or higher
            var topRatedGames = (from game in games
                                 where game.Rating >= 4
                                 select game).ToList();

            //  Sort the filtered list by game name
            var sortedGames = (from game in topRatedGames
                               orderby game.Name
                               select game).ToList();

            // Print out the sorted list of game names
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }
        }
    }
}
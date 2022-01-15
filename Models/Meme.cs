namespace MemeAPI.Models
{
    /// <summary>
    /// Contains meme data
    /// </summary>
    public class Meme
    {
        /// <summary>
        /// Meme name
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Meme URL
        /// </summary>
        public string? Link { get; set; }
    }
}
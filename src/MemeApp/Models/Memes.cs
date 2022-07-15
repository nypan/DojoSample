namespace MemeApp.Models
{
    // Använd Paste special
    // https://improveandrepeat.com/2022/01/visual-studio-2022-an-improved-paste-json-as-classes/

    public class Memes
    {
        public bool success { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Meme[] memes { get; set; }
    }

    public class Meme
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int box_count { get; set; }
    }

}

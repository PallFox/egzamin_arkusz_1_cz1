namespace egzamin_arkusz_1_cz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            StreamReader sr = new StreamReader("C:\\Users\\marcin.bulanda\\Desktop\\egzamin\\Data.txt");
            string line;
            while((line=sr.ReadLine()) != null)
            {
                try
                {
                    Song song = new Song();
                    song.Artist = line;
                    song.Album = sr.ReadLine();
                    song.songsNumber = int.Parse(sr.ReadLine());
                    song.Year = int.Parse(sr.ReadLine());
                    song.DownloadNumber = int.Parse(sr.ReadLine());
                    list.Add(song);
                }catch { }
            }
            sr.Close();

            Console.WriteLine(list);
        }
    }
}

using System.IO;
using System.Collections.Generic;
using System;

namespace PA1
{
    public class SongFile
    {
        public static List<Song> GetSongs()
        {
            List<Song> funSongs = new List<Song>();
            StreamReader inFile = null;

            try
            {
                inFile = new StreamReader("songs.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"\nSomething went wrong... returning blank list {e}\n");
                return funSongs;
            }

            string line = inFile.ReadLine(); // priming read
            while (line != null)
            {
                string[] temp = line.Split("#");
                Guid g = Guid.Parse(temp[0]);
                DateTime time = DateTime.Parse(temp[2]);
                bool delete = bool.Parse(temp[3]);
                // DateTime time = DateTime.Parse(temp[2]);
                funSongs.Add(new Song(){ID = g, Title = temp[1], Time = time, Delete = delete});
                line = inFile.ReadLine(); // update read
            }
            inFile.Close();

            return funSongs;
        }
    }
}
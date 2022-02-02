using System;
using System.Collections.Generic;
using System.IO;

namespace PA1
{
    public class SongUtil
    {
        public static void PrintAllSongs(List<Song> songs)
        {
            foreach(Song song in songs)
            {
                if (song.Delete == true)
                {
                    Console.WriteLine(song.ToString());
                }
            }
        }
        public static void AllSongsToFile(List<Song> songs)
        {
            StreamWriter outFile = new StreamWriter("songs.txt");
            // foreach (var item in songs)
            // {
            //     System.Console.WriteLine(item);
            // }
            // try
            // {
            //     outFile = new StreamWriter("songs.txt");
            // }
            // catch
            // {
            //     Console.WriteLine("Sorry, the file does not exist.");
            // }
            foreach(Song song in songs)
            {
                outFile.WriteLine($"{song.ID}#{song.Title}#{song.Time}#{song.Delete}");
            }

            outFile.Close();
        }
    }
}


using System;
using System.IO;
using System.Collections.Generic;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose from the following:\n1. Show All Songs\n2. Add a song\n3. Delete a Song by ID\n4. Exit\n");
            List<Song> funSongs = SongFile.GetSongs();

            // Console.WriteLine("\n\nSorted by time:");


            int input = int.Parse(Console.ReadLine());

            while (input != 4)
            {
                if (input != 1 && input != 2 && input != 3)
                {
                    Console.WriteLine("Sorry, you have entered incorrectly. Please enter an integer 1-4:");
                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    switch (input)
                    {
                        case 1:
                            Console.Clear();
                            // funSongs.Sort(Song.CompareByTime);
                            funSongs.Sort((x, y) => x.Time.CompareTo(y.Time));
                            funSongs.Reverse();
                            SongUtil.PrintAllSongs(funSongs);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("What is your songs title?");
                            string name = Console.ReadLine();
                            funSongs.Add(new Song(){ID = Guid.NewGuid(), Title = name, Time = DateTime.Now, Delete = true});
                            SongUtil.AllSongsToFile(funSongs);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Please enter the ID of the song you would like to delete:");
                            Guid g = Guid.Parse(Console.ReadLine());
                            // this.funSongs.FirstOrDefault(z => z.ID == iD).Delete = false;
                            foreach (Song song in funSongs)
                            {
                                if (song.ID == g)
                                {
                                    Console.WriteLine(song.Delete);
                                    song.Delete = false;
                                    Console.WriteLine(song.Delete + "\n\n");
                                }
                            // Console.WriteLine(funSongs.Exists(song => song.ID == iD));
                            }
                            SongUtil.AllSongsToFile(funSongs);

                            break;
                    }
                    Console.WriteLine("Please choose from the following:\n1. Show All Songs\n2. Add a song\n3. Delete a Song by ID\n4. Exit\n");
                    input = int.Parse(Console.ReadLine());
                    funSongs = SongFile.GetSongs();
                }
            }
        }
    }
}

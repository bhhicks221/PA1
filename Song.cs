using System;
using System.Collections.Generic;
using System.IO;

namespace PA1
{
    public class Song : IComparable<Song>
    {
        public Guid ID {get; set;}
        public string Title { get; set;}
        public DateTime Time { get; set;}
        public bool Delete { get; set;}

        public int CompareTo(Song temp)
        {
            return this.Time.CompareTo(temp.Time);
        }
        // public static DateTime CompareByTime(Song x, Song y)
        // {
        //     return x.Time.CompareTo(y.Time);
        // }
        public override string ToString()
        {
            return "ID: " + this.ID + " Song: " + this.Title + " added: " + this.Time;
        }
        // public Song GetById(int id)
        // {
        // return this.list.FirstOrDefault(z => z.Id == id);
        // }
    }
}
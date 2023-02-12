using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Bluegrass,
            Country,
            Jazz,
            Pop,
            Rock
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            //public Music(string title, string artist, string album, string length, Genre genre)
            //{
              //  Title = title;
              //  Artist = artist;
              //  Album = album;
              //  Length = length;
              //  Genre = genre;
            //}
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title:" + Title + "\nArtist:" + Artist + "\nAlbum:" + Album + "\nLength:" + Length + "\nGenre:" + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song title?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Please enter the song artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("Please enter the song album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("Please enter the song length?");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("Please enter the song genre?");
                    Console.WriteLine("B - Bluegrass\nC - Country\nJ - Jazz\nP - Pop\nR - Rock");
                    collection[i].setGenre(Genre.Bluegrass);

                    Music music = new Music();
                    Music moreMusic = music;
                    moreMusic.setTitle("New Moon");
                    moreMusic.setLength("4.3");
                    moreMusic.setAlbum("Dark side of the moon");
                    moreMusic.setArtist("Pink Floyd");
                    moreMusic.setGenre(Genre.Bluegrass);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }

    }
}

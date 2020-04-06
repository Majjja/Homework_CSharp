using System;

namespace Task_01
{
    public class PhotoAlbum
    {
        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }

        public PhotoAlbum(int numOfPages)
        {
            NumberOfPages = numOfPages;
        }

        private int NumberOfPages;

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }
    }

    public class BigPhotoAlbum
    {
        public BigPhotoAlbum()
        {
            NumberOfPages = 64;
        }

        private int NumberOfPages;
        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            PhotoAlbum defaultNumOfPages = new PhotoAlbum();
            var desiredNumOfPages = new PhotoAlbum(24);

            var bigPhotoAlbumPages = new BigPhotoAlbum();

            Console.WriteLine($"Number of pages that the three albums have are:" +
                $"\n{defaultNumOfPages.GetNumberOfPages()}\n{desiredNumOfPages.GetNumberOfPages()}" +
                $"\n{bigPhotoAlbumPages.GetNumberOfPages()}");

            Console.ReadLine();
        }
    }
}

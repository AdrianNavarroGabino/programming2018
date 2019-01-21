// Adrián Navarro Gabino

using System;

class PhotoAlbum
{
    protected int numberOfPages;
    
    public int NumberOfPages
    {
        get
        {
            return numberOfPages;
        }
        
        set
        {
            numberOfPages = value;
        }
    }
    
    public PhotoAlbum()
    {
        Console.WriteLine("I'm creating a photo album with 16 pages");
        numberOfPages = 16;
    }
    
    public PhotoAlbum(int newNumberOfPages)
    {
        Console.WriteLine("I'm creating a photo album with " +
            newNumberOfPages + " pages");
        numberOfPages = newNumberOfPages;
    }
    
    ~PhotoAlbum()
    {
        Console.WriteLine(numberOfPages + " pages album destructor");
    }
}

class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum()
    {
        Console.WriteLine("I'm creating a big photo album with 64 " +
            "pages");
        numberOfPages = 64;
    }
    
    ~BigPhotoAlbum()
    {
        Console.WriteLine(numberOfPages +
            " pages big album destructor");
    }
}

class AlbumTest
{
    static void Main()
    {
        PhotoAlbum album1 = new PhotoAlbum();
        PhotoAlbum album2 = new PhotoAlbum(24);
        BigPhotoAlbum bigAlbum = new BigPhotoAlbum();
        
        Console.WriteLine("Album 1: " + album1.NumberOfPages);
        Console.WriteLine("Album 2: " + album2.NumberOfPages);
        Console.WriteLine("Album 3: " + bigAlbum.NumberOfPages);
        
        album1.NumberOfPages = 20;
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1._title = "First Youtube Video";
        v1._author ="Jayden";
        v1._length = 102;
        v1._comments.Add(new Comment { _name = "Randomuser1", _commentText="Great vid!"});
        v1._comments.Add(new Comment { _name = "Randomuser2", _commentText="Nice editing!"});
        videos.Add(v1);

        Video v2 = new Video();
        v2._title = "First Youtube Video";
        v2._author ="Jayden";
        v2._length = 102;
        v2._comments.Add(new Comment { _name = "Randomuser1", _commentText="Great vid!"});
        v2._comments.Add(new Comment { _name = "Randomuser2", _commentText="Nice editing!"});
        videos.Add(v2);

        Video v3 = new Video();
        v3._title = "First Youtube Video";
        v3._author ="Jayden";
        v3._length = 102;
        v3._comments.Add(new Comment { _name = "Randomuser1", _commentText="Great vid!"});
        v3._comments.Add(new Comment { _name = "Randomuser2", _commentText="Nice editing!"});
        videos.Add(v3);

        foreach(Video v in videos)
        {
            v.Display();
        }

    }
}
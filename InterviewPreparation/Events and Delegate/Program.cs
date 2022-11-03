using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InterviewPreparation.Events_and_Delegate
{
    #region Events & Delegate

    // Events - is a notification mechanism that depends on delegates
    // Right to left is dependency graph
    // Function ---> Delegate  ---> Events
    // An event is dependent on delegate and can't be created without delegates
    // Event is like a wrapper over the delegate to improve it's security 
    // It is a mechanism for communication between objects
    // Used in building Loosely coupled Applications

    // Delegates
    // Agreement / Contract between publisher and subscriber
    // Determines the signature of the event handler method in subscriber

    // Events and Delegates meant for publisher / subscriber model
    // Video Encoder will encode the video and instead of sending the notification code in video
    // encoder class we can create separate MailService or MessageService Class to send the notification    

    #region Mosh Examples

    #region Version -1 

    /*

    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncoder
    {
        // Steps to create Events
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        public virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }

    public class Program
    {
        public static void Main()
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
           // Console.WriteLine("{0} {1} {2}");
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message...");
        }
    }
    
    */

    #endregion

    //If we want to send more information about video
    //we can create VideoEventArgs class inheriting from EventArgs 

    #region Version -2

    /*

    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // Steps to create Events
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        // Method - 1

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        //instead of creating delegate and event based on that delegate 
        //.Net provides EventHandler/ EventHandler<TEventArgs>

        // Method -2

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        public virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class Program
    {
        public static void Main()
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
            // Console.WriteLine("{0} {1} {2}");
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message..."+ e.Video.Title);
        }
    }

    */

    #endregion

    #endregion

    #region Passing Method as a Params

    /*
     
    public class Program
    {
        delegate void Calculate(int x, int y);
        public static void Main()
        {
            var del = new Calculate(Add);
            del(5, 2);

            var del2 = new Calculate(Multiply);
            del2(5, 2);
            //Console.WriteLine("{0} {1} {2}");
        }

        public static void Add(int a, int b)
        {
            var c = a + b;
            Console.WriteLine("Sum of a & b = {0}", c);
        }

        public static void Multiply(int a, int b)
        {
            var c = a * b;
            Console.WriteLine("Multiply of a & b = {0}", c);
        }
    }

    */

    #endregion

    #endregion
}

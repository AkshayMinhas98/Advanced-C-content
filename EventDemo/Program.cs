using System;
using System.Threading;

namespace EventDemo
{
    public class Video
    {
        public string Title { get; set; }       
    }
    public class VideoProcessor
    {
        //1. create delegate
        //2. create event based on the delegate
        //3. raise event

        public delegate void VideoProcessorEventHandler(object source, EventArgs args);
        public event VideoProcessorEventHandler VideoEvent;
        public void Process()
        {
            Console.WriteLine("Video is under Processing........");
            Thread.Sleep(5000);

            OnEventHandler();
        }

        public void OnEventHandler()     //publisher event 
        {
            VideoEvent(this, EventArgs.Empty);
        }
    }
   
    public class Subscriber1
    {
        public void call(object source,EventArgs args)
        {
            Console.WriteLine("subscriber 1");
        }
    }

    public class Subscriber2
    {
        public void call(object source, EventArgs args)
        {
            Console.WriteLine("subscriber 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var videoProcessor = new VideoProcessor();// publisher
            var sub1 = new Subscriber1();
            var sub2 = new Subscriber2();
            videoProcessor.VideoEvent += sub1.call;
            videoProcessor.VideoEvent += sub2.call;
            videoProcessor.Process();
            Console.ReadKey();
        }
    }
}

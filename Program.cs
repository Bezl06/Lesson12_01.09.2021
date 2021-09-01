using System;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Record();
            player.Stop();
        }
        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }
        interface IRecordable
        {
            void Record();
            void Pause();
            void Stop();
        }
        class Player : IPlayable, IRecordable
        {
            public void Play() => System.Console.WriteLine("Playing...");
            public void Record() => System.Console.WriteLine("Recording...");
            public void Pause() => System.Console.WriteLine("Paused");
            public void Stop() => System.Console.WriteLine("Stoped");
        }
    }
}

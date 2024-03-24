using System;
namespace SurajLabWork
{
    public delegate void Notify();
    public class Process
    {
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("started");
            Console.WriteLine("running");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
        public static void Main(string[] args)
        {
            Process p1 = new Process();
            p1.ProcessCompleted += p1_ProcessCompleted;
            p1.StartProcess();
            Console.WriteLine("\nLab No: 9f");
            Console.WriteLine("Name : Suraj Kumal");
            Console.WriteLine("Roll no : 32");
        }
        private static void p1_ProcessCompleted()
        {
            Console.WriteLine("completed");
        }


    }
}
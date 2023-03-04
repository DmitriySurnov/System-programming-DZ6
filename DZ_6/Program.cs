using System;
using System.Threading.Tasks;

namespace DZ_6
{
    class Program
    {
        static void Main(string[] args)
        {
            EventSender mySender = new EventSender();
            ClassEvents ob1 = new ClassEvents(1);
            ClassEvents ob2 = new ClassEvents(2);
            ClassEvents ob3 = new ClassEvents(3);

            Exit();

            mySender.Event2 += ob1.Event2;
            mySender.Event3 += ob1.Event3;
            mySender.Event3 += ob2.Event3;
            mySender.Event3 += ob3.Event3;
            mySender.Event4 += ob1.Event4;
            mySender.Start();
        }
        private static async void Exit()
        {
            await Task.Run(() =>
            {
                ConsoleKeyInfo keyInfo;
                do
                {
                    keyInfo = Console.ReadKey();
                } while (keyInfo.Key != ConsoleKey.Enter);
            });
            Environment.Exit(0);
        }

    }


}

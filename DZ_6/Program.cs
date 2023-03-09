using System;
using System.Threading.Tasks;

namespace DZ_6
{
    class Program
    {
        private static EventSender _mySender;
        public static Message Message;

        static void Main(string[] args)
        {
            _mySender = new EventSender();
            Message = new Message();
            Message.Start();
            ClassEvents ob1 = new ClassEvents(1);
            ClassEvents ob2 = new ClassEvents(2);
            ClassEvents ob3 = new ClassEvents(3);

            Exit();

            _mySender.Event2 += ob1.Event2;
            _mySender.Event3 += ob1.Event3;
            _mySender.Event3 += ob2.Event3;
            _mySender.Event3 += ob3.Event3;
            _mySender.Event4 += ob1.Event4;
            _mySender.Start();
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
            _mySender?.Stop();
            Message?.Stop();
            Environment.Exit(0);
        }
    }
}

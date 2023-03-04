using System;
using System.Threading;

namespace DZ_6
{
    internal class EventSender
    {
        public delegate void EventHandler();

        public event EventHandler Event1;
        public event EventHandler Event2;
        public event EventHandler Event3;
        public event EventHandler Event4;

        public void Start()
        {
            Random random = new Random();
            while (true)
            {
                int numberEvent = random.Next(1, 5);
                switch (numberEvent)
                {
                    case 1:
                        Event1?.Invoke();
                        break;
                    case 2:
                        Event2?.Invoke();
                        break;
                    case 3:
                        Event3?.Invoke();
                        break;
                    case 4:
                        Event4?.Invoke();
                        break;

                }
                Thread.Sleep(1000);
            }
        }
    }
}

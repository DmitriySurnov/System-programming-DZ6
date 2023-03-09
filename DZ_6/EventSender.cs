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

        private bool _isRunning;
        private Thread _eventThread;

        public EventSender()
        {
            _isRunning = false;
            _eventThread = new Thread(CallEvent);
        }

        public void Start()
        {
            if (_isRunning)
            {
                return;
            }
            _isRunning = true;
            _eventThread.Start();
        }
        public void Stop()
        {
            _isRunning = false;
        }

        private void CallEvent()
        {
            Random random = new Random();
            while (_isRunning)
            {
                int numberEvent = random.Next(1, 5);
                Console.WriteLine(numberEvent);
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

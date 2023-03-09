using System;
using System.Threading;

namespace DZ_6
{
    internal class ClassEvents
    {
        private readonly int _id;

        public ClassEvents(int id)
        {
            _id = id;
        }

        public void Event2()
        {
            Program.Message.AddMessage("Event 2 принят");
        }

        public void Event3()
        {
            Program.Message.AddMessage($"Event 3 принят классом с ID {_id}");
        }

        public void Event4()
        {
            //Program.Message.AddMessage("Event 4 ...");
            //Thread.CurrentThread.Join();
        }
    }
}

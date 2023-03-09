using System;
using System.Collections.Generic;
using System.Threading;

namespace DZ_6
{
    internal class Message
    {
        private List<String> _listMessages;
        private bool _isRunning;
        private Thread _currentThread;
        private Object _listMessagesLockObj;

        public void AddMessage(string text)
        {
            lock (_listMessagesLockObj)
            {
                _listMessages.Add(text);
            }
        }

        public Message()
        {
            _listMessages = new List<string>();
            _currentThread = new Thread(ShowMessage);
            _isRunning = false;
            _listMessagesLockObj = new Object();
        }

        public void Start()
        {
            if (_isRunning)
            {
                return;
            }
            _isRunning = true;
            _currentThread.Start();
        }

        public void Stop()
        {
            _isRunning = false;
        }

        private void ShowMessage()
        {
            while (_isRunning)
            {
                if (_listMessages.Count == 0)
                {
                    continue;
                }
                Console.WriteLine(_listMessages[0]);
                lock (_listMessagesLockObj)
                {
                    _listMessages.RemoveAt(0);
                }
            }
        }
    }
}

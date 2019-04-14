using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueConvert
{
    class TwoQueueStack
    {
        private Queue<int> data;
        private Queue<int> help;

        public TwoQueueStack()
        {
            data = new Queue<int>();
            help = new Queue<int>();
        }

        public void push(int pushInt)
        {
            data.Enqueue(pushInt);
        }

        public int peek()
        {
            if (data.Count == 0)
            {
                throw new Exception("Stack is empty!");
            }
            while (data.Count != 1)
            {
                help.Enqueue(data.Dequeue());
            }
            int res = data.Dequeue();
            help.Enqueue(res);
            swap();
            return res;
        }

        public int pop()
        {
            if (data.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
            while (data.Count > 1)
            {
                help.Enqueue(data.Dequeue());
            }
            int res = data.Dequeue();
            swap();
            return res;
        }

        private void swap()
        {
            Queue<int> tmp = help;
            help = data;
            data = tmp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueConvert
{
    class TwoStackQueue
    {
        private Stack<int> stackPush;
        private Stack<int> stackPop;

        public TwoStackQueue()
        {
            stackPush = new Stack<int>();
            stackPop = new Stack<int>();
        }

        public void push(int pushInt)
        {
            stackPush.Push(pushInt);
        }

        public int poll()
        {
            if(stackPop.Count == 0 && stackPush.Count == 0)
            {
                throw new Exception("Queue is empty");
            }
            else if(stackPop.Count == 0)
            {
                while(!(stackPush.Count == 0))
                {
                    stackPop.Push(stackPush.Pop());
                }
            }
            return stackPop.Peek();
        }

        public int peek()
        {
            if(stackPop.Count == 0 && stackPush.Count == 0)
            {
                throw new Exception("Queue is empty");
            }
            else if(stackPop.Count == 0)
            {
                while(!(stackPush.Count == 0))
                {
                    stackPop.Push(stackPush.Pop());
                }
            }
            return stackPop.Peek();
        }
    }
}

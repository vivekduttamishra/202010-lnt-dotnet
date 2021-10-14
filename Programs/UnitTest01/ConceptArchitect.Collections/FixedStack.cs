using System;

namespace ConceptArchitect.Collections
{
    public class FixedStack
    {

       // bool empty = true;
        public int Size { get; private set; }
        private object item;
        public int Count { get; private set; }

        public FixedStack(int size)
        {
            this.Size = size;
        }

        public bool IsEmpty 
        { 
            get 
            { 
                return Count==0; 
            } 
        }

        public bool IsFull 
        { 
            get 
            { 
                return Count==Size;
            } 
        }

        

        public void Push(object value)
        {
            if(IsFull)
                throw new ConceptArchitect.Collections.StackOverflowException(value);
            //empty = false;
            Count++;
            item = value;
            
        }

        public object Pop()
        {
            if (IsEmpty)
                throw new StackUnderflowException();
            Count--;
            return item;
        }

        public object Peek()
        {
            return item;
        }
    }
}
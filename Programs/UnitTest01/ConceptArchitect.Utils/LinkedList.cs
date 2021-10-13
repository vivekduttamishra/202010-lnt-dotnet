using System;

namespace ConceptArchitect.Utils
{
    public class LinkedList<T>
    {
        public const int POS_END= -1;
        class Node
        {
            public Node next;
            public Node previous;
            public T value;
        }

        Node first;
        Node last;
        public int Count { get; private set; }

        public LinkedList()
        {
            first = last = null;
            Count = 0;
        }
        public void add(T value)
        {
            Node newNode = new Node() { value = value, previous=last };

            if (first == null)
                first = newNode;
            else
                last.next = newNode;

            last = newNode;
            Count++;
        }

        private Node Locate(int pos = POS_END)
        {
            if (pos == POS_END) pos = Count - 1;
            if (pos < 0 || pos >= Count)
                throw new IndexOutOfRangeException("Invalid Index :"+pos);

            if (pos == Count - 1)
                return last;


            Node n = first;
            for (int i = 0; i < pos; i++)
                n = n.next;

            return n;
        }
    
    
       T this[int pos]
        {
            get
            {
                return Locate(pos).value;
            }
            set
            {
                Locate(pos).value = value;
            }
        }

        void remove(int pos)
        {
            Node d = Locate(pos);
            if (d == first)
                first = d.next;
            else
                d.previous.next = d.next;

            if (d == last)
                last = d.previous;
            else
                d.next.previous = d.previous;

        }


        public override string ToString()
        {
            if (Count == 0)
                return "(empty)";

            var str = "(\t";
            for (Node n = first; n != null; n = n.next)
                str += (n.value + "\t");
            str += ")";
            return str;
        }
    }
}

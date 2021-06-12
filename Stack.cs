using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        //region Members
        private T[] stackArray;
        private int maxLength;

        //region Properties
        public int Size { get; private set; }

        //region constructor
        public Stack(int length)
        {
            maxLength = length;
            stackArray = new T[length];
        }

        public void Push(T value)
        {
            if (Size == maxLength)
                throw new ExceededSizeException();

            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stackArray[--Size];
        }

        public T Peek()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stackArray[Size - 1];
        }

    }
}

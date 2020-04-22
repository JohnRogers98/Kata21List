using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Kata21
{
    public abstract class ZListBase : IEnumerator
    {
        protected readonly Object beginNode;

        public ZListBase()
        {
            beginNode = new ZNode
            {
                Index = -1
            };
            Current = beginNode;
        }

        private Object current;
        public Object Current
        {
            get
            {
                return current;
            }
            set
            {
                current = value;
            }
        }

        protected ZNode CurrentZNode
        {
            get
            {
                return Current as ZNode;
            }
        }

        public Boolean MoveNext()
        {
            if (CurrentZNode.NextNode != null)
            {
                Current = CurrentZNode.NextNode;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            Current = beginNode;
        }

        protected ZNode GetElementOfIndex(Int32 index)
        {
            Reset();

            for (Int32 i = CurrentZNode.Index; i < index; i++)
            {
                if (MoveNext() == false)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            return CurrentZNode;
        }
    }
}

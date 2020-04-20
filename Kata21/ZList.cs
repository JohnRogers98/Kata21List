using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Kata21
{
    public class ZList : IEnumerator
    {
        private readonly Object beginNode;

        public ZList()
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

        private ZNode CurrentZNode
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

        public void Add(String content)
        {
            CurrentZNode.NextNode = new ZNode
            {
                Index = CurrentZNode.Index + 1,
                Content = content
            };
            MoveNext();
        }

        public String GetElementOfIndex(Int32 index)
        {
            Reset();

            for(Int32 i = CurrentZNode.Index; i <= index; i++)
            {
                if(CurrentZNode.Index == index)
                {
                    return CurrentZNode.Content;
                }
                if (MoveNext() == false)
                {
                    break;
                }
            }
            throw new IndexOutOfRangeException();
        }
    }
}

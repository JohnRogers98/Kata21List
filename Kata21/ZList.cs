using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Kata21
{
    public class ZList : ZListBase
    {
        public void Add(String content)
        {
            CurrentZNode.NextNode = new ZNode
            {
                Index = CurrentZNode.Index + 1,
                Content = content
            };
            MoveNext();
        }

        public String GetContentOfIndex(Int32 index)
        {
            return GetElementOfIndex(index).Content;
        }
    }
}

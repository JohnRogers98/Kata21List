using System;
using System.Collections.Generic;
using System.Text;

namespace Kata21
{
    public class ZListTwoConnect : ZListBase
    {
        public void Add(String content)
        {
            CurrentZNode.NextNode = new ZNode
            {
                Index = CurrentZNode.Index + 1,
                Content = content,
                PreviousNode = CurrentZNode
            };
            MoveNext();
        }

        public Boolean Delete(Int32 index)
        {
            ZNode node = GetElementOfIndex(index);

            if (node != null)
            {
                var previousNode = node.PreviousNode;
                var nextNode = node.NextNode;

                if (previousNode != null)
                    previousNode.NextNode = nextNode;

                if (nextNode != null)
                    nextNode.PreviousNode = previousNode;
                return true;
            }
            return false;
        }
    }
}

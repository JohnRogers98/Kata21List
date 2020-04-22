using System;
using System.Collections.Generic;
using System.Text;

namespace Kata21
{
    public class ZNode
    {
        public String Content { get; set; }
        public ZNode NextNode { get; set; }
        public ZNode PreviousNode { get; set; }
    }
}

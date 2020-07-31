using System;
using System.Collections.Generic;
using System.Text;

namespace C_ircularLinnkedList
{
    class Node
    {
        public int info;
        public Node link;

        public Node(int i)
        {
            info = i;
            link = null;
        }

    }
}

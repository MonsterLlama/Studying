using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLlama.Studying.ComputerScience.DataStructures
{
    public class LinkNode<T>
    {
        public T Data           { get; set; }
        public LinkNode<T> Next { get; set; }

        public LinkNode(T data) : this(data, null) { }

        public LinkNode(T data, LinkNode<T> next)
        {
            Data = data;
            Next = next;
        }


    }
}

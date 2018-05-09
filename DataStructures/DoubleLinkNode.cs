using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLlama.Studying.ComputerScience.DataStructures
{
    public class DoubleLinkNode<T>
    {
        public T Data                     { get; set; }
        public DoubleLinkNode<T> Next     { get; set; }
        public DoubleLinkNode<T> Previous { get; set; }

        public DoubleLinkNode(T data) : this(data, null, null) { }

        public DoubleLinkNode(T data, DoubleLinkNode<T> next, DoubleLinkNode<T> previous)
        {
            Data = data;
            Next = next;
            Previous = previous;
        }

    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T> : IVisitable<Node<T>>
    {
        public T Value { get; }

        private List<Node<T>> children = new List<Node<T>>();

        public Node(T value)
        {
            this.Value = value;
        }

        public ReadOnlyCollection<Node<T>> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor<Node<T>> visitor)
        {
            visitor.Visit(this);
        }
    }
}

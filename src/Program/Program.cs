using System;
using System.ComponentModel.DataAnnotations;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("p1", 18);
            Person p02 = new Person("p02", 18);
            Person p3 = new Person("p3", 18);
            Person p04 = new Person("p04", 20);
            Person p5 = new Person("p5", 18);
            Person p06 = new Person("p06", 19);
            Person p7 = new Person("p7", 18);

            Node<Person> n1 = new Node<Person>(p1);
            Node<Person> n2 = new Node<Person>(p02);
            Node<Person> n3 = new Node<Person>(p3);
            Node<Person> n4 = new Node<Person>(p04);
            Node<Person> n5 = new Node<Person>(p5);
            Node<Person> n6 = new Node<Person>(p06);
            Node<Person> n7 = new Node<Person>(p7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            AgeVisitor visitor = new AgeVisitor();
            visitor.Visit(n1);
            Console.WriteLine("Suma " + visitor.AgeSum);

            LongestName visitor2 = new LongestName();
            visitor2.Visit(n1);
            Console.WriteLine("Longest " + visitor2.Longest);

            OldestSon visitor3 = new OldestSon();
            visitor3.Visit(n1);
            Console.WriteLine("Oldest " + visitor3.Oldest);
        }
    }
}

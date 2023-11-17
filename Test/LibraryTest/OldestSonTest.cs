using System.IO;
using Library;
using NUnit.Framework;

namespace LibraryTests
{
    public class OldestSonVisitorTest
    {
        [Test]
        public void OldestSonTest()
        {
            Person p1 = new Person("p1", 18);
            Person p02 = new Person("p02", 19);
            Person p3 = new Person("p3", 20);
            Node<Person> n1 = new Node<Person>(p1);
            Node<Person> n2 = new Node<Person>(p02);
            Node<Person> n3 = new Node<Person>(p3);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            OldestSon visitor = new OldestSon();

            int expected = 20;
            visitor.Visit(n1);

            Assert.That(visitor.Oldest, Is.EqualTo(expected));
        }


        [Test]
        public void OldestSonTest2()
        {
            Person p1 = new Person("p1", 21);
            Person p02 = new Person("p02", 19);
            Person p3 = new Person("p3", 5);
            Node<Person> n1 = new Node<Person>(p1);
            Node<Person> n2 = new Node<Person>(p02);
            Node<Person> n3 = new Node<Person>(p3);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            OldestSon visitor = new OldestSon();

            int expected = 19;
            visitor.Visit(n1);

            Assert.That(visitor.Oldest, Is.EqualTo(expected));
        }


        [Test]
        public void OldestSonTest3()
        {
            Person p1 = new Person("p1", 18);
            Node<Person> n1 = new Node<Person>(p1);

            OldestSon visitor = new OldestSon();

            int expected = 18;
            visitor.Visit(n1);

            Assert.That(visitor.Oldest, Is.EqualTo(expected));
        }
    }
}
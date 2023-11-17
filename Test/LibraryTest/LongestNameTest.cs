using System.IO;
using Library;
using NUnit.Framework;

namespace LibraryTests
{
    public class LongestVisitorTest
    {
        [Test]
        public void LontestTest()
        {
            Person p1 = new Person("p1", 18);
            Person p02 = new Person("p02", 19);
            Person p3 = new Person("p3", 20);
            Node<Person> n1 = new Node<Person>(p1);
            Node<Person> n2 = new Node<Person>(p02);
            Node<Person> n3 = new Node<Person>(p3);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            LongestName visitor = new LongestName();

            string expected = "p02";
            visitor.Visit(n1);

            Assert.That(visitor.Longest, Is.EqualTo(expected));
        }

    }
}
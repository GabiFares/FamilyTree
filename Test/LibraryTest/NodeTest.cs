using System.IO;
using Library;
using NUnit.Framework;

namespace LibraryTests
{
    public class NodeTest
    {
        [Test]
        public void CorrectNodeTest()
        {
            Person p1 = new Person("p1", 18);
            Node<Person> n1 = new Node<Person>(p1);

            string expected = "p1";

            Assert.That(n1.Value.Name, Is.EqualTo(expected));
        }
    }
}
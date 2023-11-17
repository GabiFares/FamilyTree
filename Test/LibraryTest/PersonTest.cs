using System.IO;
using Library;
using NUnit.Framework;

namespace LibraryTests
{
    public class PersonTest
    {
        [Test]
        public void CorrectPersonTest()
        {
            Person p1 = new Person("p1", 18);

            string expected = "p1";

            Assert.That(p1.Name, Is.EqualTo(expected));
        }

    }
}
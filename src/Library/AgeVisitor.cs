using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

public class AgeVisitor : IVisitor<Node<Person>>
{
    public int AgeSum { get; private set; } = 0;

    public void Visit(Node<Person> person)
    {
        AgeSum += person.Value.Age;
        foreach (Node<Person> human in person.Children)
        {
            human.Accept(this);
        }
    }
}
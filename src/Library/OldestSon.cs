using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

public class OldestSon : IVisitor<Node<Person>>
{
    public int Oldest { get; private set; } = int.MinValue;

    public void Visit(Node<Person> person)
    {
        if (person.Children.Count == 0)
            Oldest = person.Value.Age > Oldest
                ? person.Value.Age
                : Oldest;
        foreach (Node<Person> human in person.Children)
        {
            human.Accept(this);
        }
    }
}
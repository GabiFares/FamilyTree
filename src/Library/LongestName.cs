using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

public class LongestName : IVisitor<Node<Person>>
{
    public string Longest { get; private set; } = string.Empty;

    public void Visit(Node<Person> person)
    {
        Longest = person.Value.Name.Length > Longest.Length
            ? person.Value.Name
            : Longest;

        foreach (Node<Person> human in person.Children)
        {
            human.Accept(this);
        }
    }
}
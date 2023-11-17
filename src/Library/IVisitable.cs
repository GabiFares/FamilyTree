
namespace Library;

public interface IVisitable<T> where T : IVisitable<T>
{
    public void Accept(IVisitor<T> visitor);
}
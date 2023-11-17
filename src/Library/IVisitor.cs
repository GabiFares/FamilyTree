
using System.Linq.Expressions;

namespace Library;
public interface IVisitor<T> where T : IVisitable<T>
{
    public void Visit(T value);
}


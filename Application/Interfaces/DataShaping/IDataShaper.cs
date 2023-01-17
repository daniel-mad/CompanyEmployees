using Domain.Models;
using System.Dynamic;

namespace Application.Interfaces.DataShaping;
public interface IDataShaper<T>
{
    IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldsString);
    ShapedEntity ShapeData(T entity, string fieldsString);

}

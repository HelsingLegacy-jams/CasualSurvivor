using UnityEngine;

namespace Code.Infrastructure.View
{
  public class EntityBehaviour : MonoBehaviour, IEntityView
  {
    private GameEntity _entity;
    public GameEntity Entity => _entity;

    public void SetEntity(GameEntity entity)
    {
      _entity = entity;
      _entity.Retain(this);
      _entity.AddView(this);
    }

    public void ReleaseEntity()
    {
      _entity.Release(this);
      _entity = null;
    }
  }
}
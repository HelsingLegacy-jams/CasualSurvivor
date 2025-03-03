using UnityEngine;

namespace Code.Infrastructure.View.Factory
{
  public interface IEntityViewFactory
  {
    EntityBehaviour CreateViewForEntity(GameEntity entity, Transform parent = null);
    EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity, Transform parent = null);
  }
}
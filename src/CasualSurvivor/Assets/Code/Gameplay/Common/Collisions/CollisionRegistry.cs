using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Common.Collisions
{
  public class CollisionRegistry : ICollisionRegistry
  {
    private readonly Dictionary<int, IEntity> _entityByInstanceId = new();

    public void Register(int instanceId, IEntity entity) => 
      _entityByInstanceId[instanceId] = entity;

    public void Unregister(int instanceId) => 
      _entityByInstanceId.Remove(instanceId);

    public TEntity Get<TEntity>(int instanceId) where TEntity : class =>
      _entityByInstanceId.TryGetValue(instanceId, out IEntity entity)
        ? entity as TEntity
        : null;
  }
}
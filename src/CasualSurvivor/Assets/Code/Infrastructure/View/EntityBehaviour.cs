using Code.Gameplay.Common.Collisions;
using Code.Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View
{
  public class EntityBehaviour : MonoBehaviour, IEntityView
  {
    private ICollisionRegistry _collisions;
    private GameEntity _entity;
    
    public GameEntity Entity => _entity;

    [Inject]
    public void Construct(ICollisionRegistry collisions) => 
      _collisions = collisions;

    public void SetEntity(GameEntity entity)
    {
      _entity = entity;
      _entity.Retain(this);
      _entity.AddView(this);

      foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>()) 
        registrar.RegisterComponent();
      
      foreach (Collider collider in GetComponentsInChildren<Collider>()) 
        _collisions.Register(collider.GetInstanceID(), Entity);
    }

    public void ReleaseEntity()
    {
      foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>()) 
        registrar.UnregisterComponent();

      foreach (Collider collider in GetComponentsInChildren<Collider>()) 
        _collisions.Unregister(collider.GetInstanceID());
      
      _entity.Release(this);
      _entity = null;
    }
  }
}
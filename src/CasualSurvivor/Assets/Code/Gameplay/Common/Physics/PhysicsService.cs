using Code.Common.Extensions;
using Code.Gameplay.Common.Collisions;
using UnityEngine;

namespace Code.Gameplay.Common.Physics
{
  public class PhysicsService : IPhysicsService
  {
    private static readonly RaycastHit[] Hit = new RaycastHit[8];
    
    private readonly ICollisionRegistry _collisionRegistry;

    public PhysicsService(ICollisionRegistry collisionRegistry)
    {
      _collisionRegistry = collisionRegistry;
    }

    public Vector3 RaycastPoint(Vector2 point, Camera camera, float distance = 20f,
      CollisionLayer layer = CollisionLayer.Walkable)
    {
      Ray ray = camera.ScreenPointToRay(point);
      
      int hitCount = UnityEngine.Physics.RaycastNonAlloc(ray, Hit, distance, layer.AsMask());
      for (int i = 0; i < hitCount; i++)
        return Hit[i].point;
      
      return Vector3.zero;
    }
    
    public GameEntity Raycast(Vector2 point, Camera mainCamera, float distance = 30f, 
      CollisionLayer layer = CollisionLayer.Interactable)
    {
      Ray ray = mainCamera.ScreenPointToRay(point);
      
      int hitCount = UnityEngine.Physics.RaycastNonAlloc(ray, Hit, distance, layer.AsMask());

      for (int i = 0; i < hitCount; i++)
      {
        RaycastHit hit = Hit[i];
        if(hit.collider == null)
          continue;

        GameEntity entity = _collisionRegistry.Get<GameEntity>(hit.collider.GetInstanceID());
        if(entity == null)
          continue;

        return entity;
      }
      return null;
    }
  }
}
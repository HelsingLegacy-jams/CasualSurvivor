using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Factory
{
  public class CameraFactory : ICameraFactory
  {
    public GameEntity CreateCamera()
    {
      return CreateEntity.Empty()
          .AddWorldPosition(Vector3.zero)
          .AddViewPath("Camera/MainCamera")
        
          .With(x=>x.isFocusedCamera = true)
        ;
    }
  }
}
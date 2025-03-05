using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras.Registrars
{
  public class MainCameraRegistrar :EntityComponentRegistrar
  {
    public Camera MainCamera;
    
    public override void RegisterComponent() => 
      Entity.AddMainCamera(MainCamera);

    public override void UnregisterComponent()
    {
      if(Entity.hasMainCamera)
        Entity.RemoveMainCamera();
    }
  }
}
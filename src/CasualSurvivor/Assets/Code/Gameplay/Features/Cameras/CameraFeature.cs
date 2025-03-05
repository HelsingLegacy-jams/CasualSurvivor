using Code.Gameplay.Features.Cameras.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Cameras
{
  public sealed class CameraFeature : Feature
  {
    public CameraFeature(ISystemFactory systems)
    {
      Add(systems.Create<InitializeCameraFeature>());
    }
  }
}
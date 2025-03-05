using Code.Gameplay.Features.Cameras.Factory;
using Code.Gameplay.Features.Cameras.Service;
using Entitas;

namespace Code.Gameplay.Features.Cameras.Systems
{
  public class InitializeCameraFeature : IInitializeSystem
  {
    private readonly ICameraFactory _factory;
    private readonly ICameraProvider _provider;

    public InitializeCameraFeature(ICameraFactory factory, ICameraProvider provider)
    {
      _factory = factory;
      _provider = provider;
    }

    public void Initialize() => 
      _provider.SetEntity(_factory.CreateCamera());
  }
}
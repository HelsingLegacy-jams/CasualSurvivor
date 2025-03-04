using Code.Gameplay.Features.Input.Factory;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InitializeInputSystem : IInitializeSystem
  {
    private readonly IInputFactory _factory;

    public InitializeInputSystem(IInputFactory factory) => 
      _factory = factory;

    public void Initialize() =>
      _factory.CreateInput();
  }
}
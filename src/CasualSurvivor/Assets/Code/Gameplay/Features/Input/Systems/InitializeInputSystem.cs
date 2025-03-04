using Code.Gameplay.Features.Input.Factory;
using Code.Gameplay.Features.Input.Service;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InitializeInputSystem : IInitializeSystem
  {
    private readonly IInputFactory _factory;
    private readonly IInputService _input;

    public InitializeInputSystem(IInputFactory factory, IInputService input)
    {
      _factory = factory;
      _input = input;
    }

    public void Initialize()
    {
      _input.SetEntity(_factory.CreateInput());
    }
  }
}
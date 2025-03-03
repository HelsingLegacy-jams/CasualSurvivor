using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Input.Factory
{
  public class InputFactory : IInputFactory
  {
    public GameEntity CreateInput()
    {
      return CreateEntity.Empty()
        .AddViewPath("Input/Input")
        .AddWorldPosition(Vector3.zero)

        .With(x => x.isInput = true);
        ;
    }
  }
}
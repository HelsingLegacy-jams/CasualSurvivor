using System.Collections.Generic;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Features.Cameras.Service;
using Entitas;

namespace Code.Gameplay.Features.Input.Systems
{
  public class InputDestinationProvidingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _inputs;
    private readonly IGroup<GameEntity> _heroes;
    
    private readonly IPhysicsService _physics;
    private readonly ICameraProvider _camera;
    private readonly List<GameEntity> _buffer = new (1);

    public InputDestinationProvidingSystem(GameContext game, IPhysicsService physics, ICameraProvider camera)
    {
      _physics = physics;
      _camera = camera;
      _inputs = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Input,
          GameMatcher.CursorPosition,
          GameMatcher.MovingProvided));
      
      _heroes = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Hero)
        .NoneOf(GameMatcher.Busy));
    }

    public void Execute()
    {
      foreach (GameEntity input in _inputs)
      foreach (GameEntity hero in _heroes.GetEntities(_buffer))
      {
        hero.ReplaceDestination(_physics.RaycastPoint(input.CursorPosition, _camera.Entity.MainCamera));
        hero.isMoving = input.isMovingProvided;
      }
    }
  }
}
using Code.Infrastructure.View.Factory;
using Entitas;

namespace Code.Infrastructure.View.Systems
{
  public class BindViewFromPathSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _entities;
    private readonly IEntityViewFactory _factory;

    public BindViewFromPathSystem(GameContext game, IEntityViewFactory factory)
    {
      _factory = factory;
      _entities = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.ViewPath, 
          GameMatcher.WorldPosition)
        .NoneOf(GameMatcher.View));
    }

    public void Execute()
    {
      foreach (GameEntity entity in _entities)
      {
        _factory.CreateViewForEntity(entity);
      }
    }
  }
}
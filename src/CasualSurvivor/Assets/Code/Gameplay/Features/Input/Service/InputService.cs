namespace Code.Gameplay.Features.Input.Service
{
  public class InputService : IInputService
  {
    private GameEntity _entity;
    public GameEntity Entity => _entity;

    public void SetEntity(GameEntity entity) => 
      _entity = entity;
  }
}
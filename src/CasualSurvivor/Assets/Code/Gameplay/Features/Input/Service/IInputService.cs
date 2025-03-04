namespace Code.Gameplay.Features.Input.Service
{
  public interface IInputService
  {
    GameEntity Entity { get; }
    void SetEntity(GameEntity entity);
  }
}
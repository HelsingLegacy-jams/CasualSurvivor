namespace Code.Gameplay.Features.Cameras.Service
{
  public interface ICameraProvider
  {
    GameEntity Entity { get; }
    void SetEntity(GameEntity entity);
  }
}
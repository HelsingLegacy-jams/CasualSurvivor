namespace Code.Gameplay.Features.Cameras.Service
{
  public class CameraProvider : ICameraProvider
  {
    private GameEntity _entity;
    public GameEntity Entity => _entity;

    public void SetEntity(GameEntity entity) => 
      _entity = entity;
  }
}
using Code.Infrastructure.Scenes;

namespace Code.Infrastructure.States
{
  public class BootstrapState : IState
  {
    private readonly IGameStateMachine _stateMachine;
    private readonly ISceneLoader _sceneLoader;

    public BootstrapState(ISceneLoader sceneLoader, IGameStateMachine stateMachine)
    {
      _sceneLoader = sceneLoader;
      _stateMachine = stateMachine;
    }

    public void Enter()
    {
      _sceneLoader.Load("Main", MoveToLoadLevelState);
    }

    private void MoveToLoadLevelState() => 
      _stateMachine.Enter<LoadLevelState>();

    public void Exit()
    {
    }
  }
}
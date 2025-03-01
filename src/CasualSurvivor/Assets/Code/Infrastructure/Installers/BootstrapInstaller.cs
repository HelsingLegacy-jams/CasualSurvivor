using Code.Infrastructure.States;
using Code.Infrastructure.States.Factory;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable
  {
    public void Initialize()
    {
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
    }

    public override void InstallBindings()
    {
      BindInstaller();
      BindInfrastructureServices();
    }

    private void BindInfrastructureServices()
    {
      Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
      Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
    }

    private void BindInstaller() =>
      Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
  }
}
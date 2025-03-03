using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Features.Input.Factory;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Scenes;
using Code.Infrastructure.Services;
using Code.Infrastructure.States;
using Code.Infrastructure.States.Factory;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View.Factory;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public void Initialize()
    {
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
    }

    public override void InstallBindings()
    {
      BindInstaller();
      BindInfrastructureServices();
      BindContexts();
      BindGameplayFactories();
    }

    private void BindGameplayFactories()
    {
      Container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();
      Container.Bind<IInputFactory>().To<InputFactory>().AsSingle();
    }

    private void BindContexts()
    {
      Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
      
      Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
    }

    private void BindInfrastructureServices()
    {
      Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();

      Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
      Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
      
      Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
      Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
    }

    private void BindInstaller() =>
      Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
  }
}
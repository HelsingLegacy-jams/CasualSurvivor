using Zenject;

namespace Code.Infrastructure.States.Factory
{
  public class StateFactory : IStateFactory
  {
    private readonly IInstantiator _instantiator;

    public StateFactory(IInstantiator instantiator) => 
      _instantiator = instantiator;

    public TState Create<TState>() where TState : IState => 
      _instantiator.Instantiate<TState>();

    public TState Create<TState>(params object[] args) where TState : IState => 
      _instantiator.Instantiate<TState>(args);
  }
}
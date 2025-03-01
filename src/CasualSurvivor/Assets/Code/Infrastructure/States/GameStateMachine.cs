using System;
using System.Collections.Generic;
using Code.Infrastructure.States.Factory;

namespace Code.Infrastructure.States
{
  public class GameStateMachine : IGameStateMachine
  {
    private IState _activeState;
    private readonly Dictionary<Type, IState> _states;

    public GameStateMachine(IStateFactory factory)
    {
      _states = new Dictionary<Type, IState>
      {
        [typeof(BootstrapState)] = factory.Create<BootstrapState>(this),
        [typeof(LoadLevelState)] = factory.Create<LoadLevelState>(),
      };
    }

    public void Enter<TState>() where TState : IState
    {
      _activeState?.Exit();
      
      IState state = _states[typeof(TState)];
      _activeState = state;
      state.Enter();
    } 
  }
}
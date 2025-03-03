using Entitas;
using Zenject;

namespace Code.Infrastructure.Systems
{
  public class SystemFactory : ISystemFactory
  {
    private readonly IInstantiator _instantiator;

    public SystemFactory(IInstantiator instantiator)
    {
      _instantiator = instantiator;
    }

    public T Create<T>() where T : ISystem => 
      _instantiator.Instantiate<T>();

    public T Create<T>(params object[] args) where T : ISystem => 
      _instantiator.Instantiate<T>(args);
  }
}
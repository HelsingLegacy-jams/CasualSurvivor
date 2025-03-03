using Code.Gameplay.Hero.Factory;
using Entitas;

namespace Code.Gameplay.Hero.Systems
{
  public class InitializeHeroSystem : IInitializeSystem
  {
    private readonly IHeroFactory _factory;

    public InitializeHeroSystem(IHeroFactory factory)
    {
      _factory = factory;
    }

    public void Initialize()
    {
      _factory.CreateHero();
    }
  }
}
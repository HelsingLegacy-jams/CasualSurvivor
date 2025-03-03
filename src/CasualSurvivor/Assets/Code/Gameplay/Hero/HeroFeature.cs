using Code.Gameplay.Hero.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Hero
{
  public sealed class HeroFeature : Feature
  {
    public HeroFeature(ISystemFactory systems)
    {
      Add(systems.Create<InitializeHeroSystem>());
    }
  }
}
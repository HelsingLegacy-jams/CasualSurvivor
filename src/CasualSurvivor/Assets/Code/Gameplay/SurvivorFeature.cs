using Code.Gameplay.Hero;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Gameplay
{
  public sealed class SurvivorFeature : Feature
  {
    public SurvivorFeature(ISystemFactory systems)
    {
      Add(systems.Create<BindViewFeature>());
      
      Add(systems.Create<HeroFeature>());
    }
  }
}
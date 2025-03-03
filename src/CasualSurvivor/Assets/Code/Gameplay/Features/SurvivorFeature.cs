using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Input;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View;

namespace Code.Gameplay.Features
{
  public sealed class SurvivorFeature : Feature
  {
    public SurvivorFeature(ISystemFactory systems)
    {
      Add(systems.Create<BindViewFeature>());
      
      Add(systems.Create<InputFeature>());
      Add(systems.Create<HeroFeature>());
    }
  }
}
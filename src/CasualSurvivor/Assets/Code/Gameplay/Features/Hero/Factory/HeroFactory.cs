using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Factory
{
  public class HeroFactory : IHeroFactory
  {
    public GameEntity CreateHero()
    {
      return CreateEntity.Empty()
        .AddViewPath("Hero/Hero")
        .AddWorldPosition(Vector3.zero)

        .With(x => x.isHero = true);
    }
  }
}
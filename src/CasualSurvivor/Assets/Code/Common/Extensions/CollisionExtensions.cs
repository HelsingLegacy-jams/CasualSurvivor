using Code.Gameplay.Common.Collisions;

namespace Code.Common.Extensions
{
  public static class CollisionExtensions
  {
    public static int AsMask(this CollisionLayer layer) => 
      1 << (int)layer;
  }
}
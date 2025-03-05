using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement
{
  [Game] public class Moving : IComponent {}
  [Game] public class MovementAvailable : IComponent {}
  
  [Game] public class Direction : IComponent { public Vector3 Value; }
  [Game] public class Destination : IComponent { public Vector3 Value; }
}
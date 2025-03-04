using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Input
{
  [Game] public class Input : IComponent {}
  [Game] public class Interacted : IComponent {}
  [Game] public class MovingProvided : IComponent {}
  
  [Game] public class CursorPosition : IComponent { public Vector2 Value; }
}
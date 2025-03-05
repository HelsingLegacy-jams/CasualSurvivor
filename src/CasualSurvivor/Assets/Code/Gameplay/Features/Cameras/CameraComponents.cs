using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Cameras
{
  [Game] public class FocusedCamera : IComponent {}
  [Game] public class MainCamera : IComponent { public Camera Value; }
}
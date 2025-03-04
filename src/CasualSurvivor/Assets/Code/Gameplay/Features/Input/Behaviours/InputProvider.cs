using Code.Gameplay.Features.Input.Service;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Gameplay.Features.Input.Behaviours
{
  public class InputProvider : MonoBehaviour
  {
    private IInputService _input;

    public void OnMove(InputValue value) => 
      _input.Entity.isMovingProvided = true;

    public void OnLook(InputValue value) => 
      _input.Entity.ReplaceCursorPosition(value.Get<Vector2>());

    public void OnInteract(InputValue value) => 
      _input.Entity.isInteracted = true;
  }
}
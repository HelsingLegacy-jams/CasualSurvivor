using Code.Gameplay.Features.Input.Service;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Gameplay.Features.Input.Behaviours
{
  public class InputProvider : MonoBehaviour
  {
    private IInputService _input;
    private Vector2 _cursorLastPosition;

    public void OnMove(InputValue value)
    {
      _input.Entity.ReplaceCursorPosition(_cursorLastPosition);
    }

    public void OnLook(InputValue value) => _cursorLastPosition = value.Get<Vector2>();

    public void OnInteract(InputValue value)
    {
      _input.Entity.ReplaceCursorPosition(_cursorLastPosition);
      _input.Entity.isInteracted = true;
    }
  }
}
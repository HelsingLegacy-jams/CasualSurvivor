using System.Collections;
using UnityEngine;

namespace Code.Infrastructure.Services
{
  public interface ICoroutineRunner
  {
    Coroutine StartCoroutine(IEnumerator enumerator);
  }
}
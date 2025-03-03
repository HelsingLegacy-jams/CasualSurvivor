using Code.Gameplay;
using Code.Infrastructure.Systems;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure
{
  public class EcsRunner : MonoBehaviour
  {
    private SurvivorFeature _survivorFeature;
    private ISystemFactory _systems;

    [Inject]
    public void Construct(ISystemFactory systems) => 
      _systems = systems;

    private void Start()
    {
      _survivorFeature = _systems.Create<SurvivorFeature>();
      _survivorFeature.Initialize();
    }

    private void Update()
    {
      _survivorFeature.Execute();
      _survivorFeature.Cleanup();
    }

    private void OnDestroy() => 
      _survivorFeature.TearDown();
  }
}
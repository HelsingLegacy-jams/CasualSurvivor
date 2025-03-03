using Code.Infrastructure.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View.Factory
{
  public class EntityViewFactory : IEntityViewFactory
  {
    private readonly IAssetProvider _assets;
    private readonly IInstantiator _instantiator;

    public EntityViewFactory(IAssetProvider assets, IInstantiator instantiator)
    {
      _assets = assets;
      _instantiator = instantiator;
    }

    public EntityBehaviour CreateViewForEntity(GameEntity entity, Transform parent = null)
    {
      EntityBehaviour viewPrefab = _assets.LoadAsset<EntityBehaviour>(entity.ViewPath);
      EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
        viewPrefab,
        entity.WorldPosition,
        Quaternion.identity,
        parent);
      
      view.SetEntity(entity);
      
      return view;
    }
    public EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity, Transform parent = null)
    {
      EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
        entity.ViewPrefab,
        entity.WorldPosition,
        Quaternion.identity,
        parent);
      
      view.SetEntity(entity);
      
      return view;
    }
  }
}
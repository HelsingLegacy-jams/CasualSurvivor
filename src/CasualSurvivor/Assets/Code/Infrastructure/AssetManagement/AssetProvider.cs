using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
  public class AssetProvider : IAssetProvider
  {
    public T LoadAsset<T>(string viewPath) where T : Component => 
      Resources.Load<T>(viewPath);
  }
}
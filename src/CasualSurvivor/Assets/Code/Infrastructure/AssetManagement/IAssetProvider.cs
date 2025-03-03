using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
  public interface IAssetProvider
  {
    T LoadAsset<T>(string viewPath) where T : Component;
  }
}
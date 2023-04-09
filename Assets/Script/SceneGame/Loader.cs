using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public class Loader : MonoBehaviour
  {
    [SerializeField]
    public SceneName sceneName;
    private MapPoint mapPoint;
    public void Load()
    {
      SceneManager.LoadSceneAsync(sceneName.ToString());
    }
    public enum SceneName
    {
      Menu,
      Scene3d,
      MapGame,
      Infinity,
      Loader,
      Levels
    }
  }
}

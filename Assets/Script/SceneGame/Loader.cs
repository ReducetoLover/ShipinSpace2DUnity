using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public class Loader : MonoBehaviour
  {
    [SerializeField]
    private SceneName _sceneName;
    public void Load()
    {
      SceneManager.LoadSceneAsync(_sceneName.ToString());
    }
    public enum SceneName
    {
      MapGame,
      Loader,
      Menu,
      Level1,
      Level2,
      Level3,
      Level4,
      Level5,
      Scene3d
    }
  }
}

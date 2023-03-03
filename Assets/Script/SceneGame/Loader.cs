using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public class Loader : MonoBehaviour
  {
    [SerializeField]
    public SceneName _sceneName;
    public void Load()
    {
      SceneManager.LoadSceneAsync(_sceneName.ToString());
    }
    public enum SceneName
    {
      Menu,
      Level1 = 1,
      Level2 = 2,
      Level3 = 3,
      Level4 = 4,
      Level5 = 5,
      Scene3d,
      MapGame,
      Loader  
    }
  }
}

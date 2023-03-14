using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public class SaveToPlayerPrefs : MonoBehaviour
  {
    public void SaveLevel()
    {
      if (SceneManager.GetActiveScene().buildIndex + 1 > PlayerPrefs.GetInt("levels"))
      {
        PlayerPrefs.SetInt("levels", SceneManager.GetActiveScene().buildIndex + 1);
      }
    }
    public void Scorekillbot()
    {
      print($"засчитало+{Singleton<FromScript>.Instance.NameScript()}");
      PlayerPrefs.SetInt("kill", PlayerPrefs.GetInt("kill") + 1);
    }
  }
}

using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public  class SaveToPlayerPrefs: MonoBehaviour
  {
    public static void SaveLevel()
    {
      if (SceneManager.GetActiveScene().buildIndex + 1 > PlayerPrefs.GetInt("levels"))
      {
        PlayerPrefs.SetInt("levels", SceneManager.GetActiveScene().buildIndex + 1);
      }
    }
    public static void Scorekillbot()
    {
      PlayerPrefs.SetInt("kill", PlayerPrefs.GetInt("kill") + 1);
    }
    public static string RecordInfinity(string value)
    {
      if (PlayerPrefs.GetInt("scorerecord") < Convert.ToInt32(value))
      {
        PlayerPrefs.SetInt("scorerecord", Convert.ToInt32(value));
        return value;
      }
      return Convert.ToString(PlayerPrefs.GetInt("scorerecord"));
    }
    
  }
}

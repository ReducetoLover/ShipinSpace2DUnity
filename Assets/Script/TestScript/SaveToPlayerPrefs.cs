using System;
using UnityEngine;

namespace Reducer
{
  public class SaveToPlayerPrefs : MonoBehaviour
  {
    public static void SaveLevel()
    {
      print(PlayerPrefs.GetInt("indexlvl"));
      print(PlayerPrefs.GetInt("levels"));
      if (PlayerPrefs.GetInt("indexlvl") > PlayerPrefs.GetInt("levels"))
      {
        PlayerPrefs.SetInt("levels", PlayerPrefs.GetInt("indexlvl"));
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

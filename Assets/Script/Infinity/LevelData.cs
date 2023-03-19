using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
  [CreateAssetMenu(fileName = "Infinity", menuName = "GameSo/Levels")]
  public class LevelData : ScriptableObject
  {
    public List<Wave> Waves = new List<Wave>();
   // public List<SettingLevel> SettingLevels = new List<SettingLevel>();
  }
  [System.Serializable]
  public class Wave
  {
    public GameObject EnemyPrefab;
    [Range(1,100)]
    public int CountinWave;
    [Range(1, 360)]
    public int WaitAfterWave;
  }
  //[System.Serializable]
  //public class SettingLevel
  //{
  //  public GameObject game;
  //}
}

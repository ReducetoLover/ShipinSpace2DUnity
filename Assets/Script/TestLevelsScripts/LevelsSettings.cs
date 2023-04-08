using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Reducer
{
  [CreateAssetMenu(fileName = "Level ", menuName = "GameSo/Levels")]

  public class LevelsSettings : ScriptableObject
  {
    public Color colorSky;
    public Sprite player;
    [Range(1, 100)]
    [Header("Settings bot")]
    public int MinXP;
    [Range(1, 100)]
    public int MaxXP;
    [Range(1, 100)]
    public float MinRespawnbot;
    [Range(1, 100)]
    public float MaxRespawnbot;
    [Range(1, 100)]
    public float MinFirebot;
    [Range(1, 100)]
    public float MaxFirebot;
    [Header("Settings achive")]
    [Range(0, 300)]
    public int Time;
    [Range(0, 100)]
    public int Kill;
    //public List<Level> Waves = new List<Level>();
  }
  // public List<SettingLevel> SettingLevels = new List<SettingLevel>();
}

[System.Serializable]
public class Level
{
  
}
//[System.Serializable]
//public class SettingLevel
//{
//  public GameObject game;
//}
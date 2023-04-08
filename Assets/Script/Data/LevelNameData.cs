using UnityEngine;

namespace Reducer
{
  public class LevelNameData
  {
    private const string Key = "SceneName";
    private const string KeyLevelIndex = "LevelIndex";
    public void Setname(string name)
    {
      Debug.Log($"{name} - запомнил название уровня");
      PlayerPrefs.SetString(Key, name);
      PlayerPrefs.Save();
    }
    public string GetName()
    {
      if (PlayerPrefs.HasKey(Key))
      {
        return PlayerPrefs.GetString(Key);
      }
      return null;
    }
    public void SetLevelIndex(int value)
    {
      Debug.Log($"index {value}");
      PlayerPrefs.SetInt(KeyLevelIndex, value);
      PlayerPrefs.Save();
    }
    public int GetLevelIndex()
    {
      if (PlayerPrefs.HasKey(KeyLevelIndex))
      {
        return PlayerPrefs.GetInt(KeyLevelIndex);
      }
      return 0;
    }
  }
}

using UnityEngine;

namespace Reducer
{
  public class SkinPlayer : MonoBehaviour
  {
    private LevelsSettings levelsSettings;
    void Start()
    {
      levelsSettings = Resources.Load<LevelsSettings>($"Levels/{PlayerPrefs.GetString("CurrentLevel")}");
      gameObject.GetComponent<SpriteRenderer>().sprite = levelsSettings.player;
    }
  }
}

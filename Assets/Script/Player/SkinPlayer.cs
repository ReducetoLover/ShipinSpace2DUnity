using UnityEngine;

namespace Reducer
{
  public class SkinPlayer : MonoBehaviour
  {
    private LevelsSettings levelsSettings;
    // Start is called before the first frame update
    void Start()
    {
      levelsSettings = Resources.Load<LevelsSettings>($"Levels/{PlayerPrefs.GetString("CurrentLevel")}");
      gameObject.GetComponent<SpriteRenderer>().sprite = levelsSettings.player;
    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}

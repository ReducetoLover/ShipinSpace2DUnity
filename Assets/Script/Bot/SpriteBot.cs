using UnityEngine;

namespace Reducer
{
  public class SpriteBot : MonoBehaviour
  {
    private LevelsSettings levelsSettings;
    [SerializeField] private Sprite[] sprites;
    void Start()
    {
      levelsSettings = Resources.Load<LevelsSettings>($"Levels/{PlayerPrefs.GetString("CurrentLevel")}");
      gameObject.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
      //gameObject.GetComponent<SpriteRenderer>().sprite =levelsSettings.bot;
    }
  }

}

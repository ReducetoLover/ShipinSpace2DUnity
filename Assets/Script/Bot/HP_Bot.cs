using UnityEngine;

namespace Reducer
{
  public class HP_Bot : MonoBehaviour
  {
    private LevelsSettings levelSettings;
    private Vector3 placeafterdestroy;
    private int animated = 0;
    [SerializeField] private BulletPlayer bulletSpeed;
    [SerializeField] private HPBar hpBar;
    [SerializeField] private int health = 0;
    private void Awake()
    {
      int index = new LevelNameData().GetLevelIndex();
      levelSettings = Resources.Load<LevelsSettings>($"Levels/{PlayerPrefs.GetString("CurrentLevel")}");
      HPbotPurpose();
    }
    private int HPbotPurpose()
    {
      return health = Random.Range(levelSettings.MinXP, levelSettings.MaxXP + 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "bullet")
      {
        Singleton<AnimateDetanationandmusic>.Instance.Hit();
        hpBar.width -= hpBar.width / health;
        health -= bulletSpeed.damage;
        hpBar.sprite.size = new Vector2(hpBar.width, 0.56f);
        if (health <= 0)
        {
          SaveToPlayerPrefs.Scorekillbot();
          if (GameObject.Find("AchiveKill") == true)
          {
            Singleton<AchiveControl>.Instance.CountKills();
          }
          if (animated == 0)
          {
            Singleton<AnimateDetanationandmusic>.Instance.PlayAnimateDetonationBot(placeafterdestroy = transform.position);
            animated = 1;
            Destroy(gameObject);
          }
        }
      }

    }
  }
}

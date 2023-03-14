using UnityEngine;

namespace Reducer
{
  public class HP_Bot : MonoBehaviour
  {
    private Vector3 placeafterdestroy;
    private int animated = 0;
    [SerializeField] private GameObject bot;
    [SerializeField] private BulletPlayer bulletSpeed;
    [SerializeField] private HPBar hpBar;
    //public RespawnBot respawnBot;
    private int health = 0;
    private void Start()
    {

    }
    private void Awake()
    {
      HPbotPurpose();
    }
    public int HPbotPurpose()
    {
      return health = Random.Range(Singleton<RespawnBot>.Instance.minXP, Singleton<RespawnBot>.Instance.maxXP);
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
          Singleton<SaveToPlayerPrefs>.Instance.Scorekillbot();
          if (GameObject.Find("AchiveKill") == true)
          {
            print($"bot+{Singleton<FromScript>.Instance.NameScript()}");
            Singleton<AchiveControl>.Instance.CountKills();
            print("Засчитало кил");

          }
          if (animated == 0)
          {
            Singleton<AnimateDetanationandmusic>.Instance.PlayAnimateDetonationBot(placeafterdestroy = bot.transform.position);
            animated = 1;
            Destroy(bot);
          }
        }
      }

    }
  }
}

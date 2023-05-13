using UnityEngine;

namespace Reducer
{
  public class HPbot3D : MonoBehaviour
  {
    private ThreeDSettings threeDSettings;
    private Vector3 placeafterdestroy;
    private int animated = 0;
    [SerializeField] private BulletPlayer bulletSpeed;
    [SerializeField] private HPBar hpBar;
    [SerializeField] private int health = 0;
    private void Awake()
    {
      threeDSettings = Resources.Load<ThreeDSettings>($"Levels/3DLevel");
      HPbotPurpose();
    }
    private int HPbotPurpose()
    {
      return health = Random.Range(threeDSettings.MinXP, threeDSettings.MaxXP + 1);
    }
    private void OnTriggerEnter(Collider collision)
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
            Singleton<AchieveControl3D>.Instance.CountKills();
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


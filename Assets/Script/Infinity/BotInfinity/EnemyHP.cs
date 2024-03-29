using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class EnemyHP : MonoBehaviour
  {
    private Vector3 placeafterdestroy;
    private int animated = 0;
    [SerializeField] private BulletPlayer bulletSpeed;
    [SerializeField] private HPBar hpBar;
    [SerializeField] private int health = 0;
    [SerializeField] private UnityEvent HPbot;
    private void Start()
    {
      HPbotPurpose();
    }
    private int HPbotPurpose()
    {
       return health = Random.Range(1, 10);
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
          if (animated == 0)
          {
            Singleton<AnimateDetanationandmusic>.Instance.PlayAnimateDetonationBot(placeafterdestroy = transform.position);
            animated = 1;
            HPbot.Invoke();
            Destroy(gameObject);
          }
        }
      }

    }
  }
}


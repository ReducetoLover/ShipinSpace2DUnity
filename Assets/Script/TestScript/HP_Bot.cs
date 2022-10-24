using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
  public class HP_Bot : MonoBehaviour
  {
    Vector3 a;
    public int animated = 0;
    public GameObject bot;
    public BulletPlayer bulletSpeed;
    public HPBar hpBar;
    public int health = 0;
    private void Start()
    {
      
    }
    void Awake()
    {
      HPbotPurpose();
    }
    public int HPbotPurpose()
    {
      return health = Random.Range(RespawnBot.instance.minXP, RespawnBot.instance.maxXP);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "bullet")
      {
        AnimateDetanationandmusic.instance.hit.Play();
        hpBar.width -= hpBar.width / health;
        health -= bulletSpeed.damage;
        hpBar.sprite.size = new Vector2(hpBar.width, 0.56f);
        if (health <= 0)
        {
          Textkillinmap.instance.Scorekillbot();
          if (GameObject.Find("Achivekills") == true)
          {
            print($"bot+{FromScript.instance.NameScript()}");
            if (AchiveControl.instance.nowkill < AchiveControl.instance.wantkill)
            {
              AchiveControl.instance.nowkill += 1;

            }
          }
          if (animated == 0)
          {
            AnimateDetanationandmusic.instance.play(a = bot.transform.position);
            animated = 1;
            Destroy(bot);
          }
        }
      }

    }
  }
}
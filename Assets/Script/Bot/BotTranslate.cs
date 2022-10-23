using UnityEngine;

namespace Reducer
{
  public class BotTranslate : MonoBehaviour
  {
    Vector3 a;
    public AudioSource hitAudio;
    public static BotTranslate instance;
    [SerializeField] private Sprite[] sprites;
    public int animated = 0;
    public GameObject player;
    public GameObject bot;
    public BulletPlayer bulletSpeed;
    public HPBar hpBar;
    private int health = 0;
    public int Scorekill = 0;

    private void Start()
    {
      instance = this;//this
    }
    void Update()
    {
      //this
      transform.Translate(Vector2.down * 2 * Time.deltaTime);
    }
    void Awake()
    {
      gameObject.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
      HPbot();
    }
    private int HPbot()
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

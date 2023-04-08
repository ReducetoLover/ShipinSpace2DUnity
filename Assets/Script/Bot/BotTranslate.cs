using UnityEngine;

namespace Reducer
{
  public class BotTranslate : MonoBehaviour
  {
    [SerializeField] private Transform bot;
    [SerializeField] private RaycastHit2D hitbot;
    [SerializeField] private GameObject border;
    [SerializeField] private GameObject player;
    [SerializeField] private bool workRay = true;
    private void Start()
    {
      border = GameObject.FindGameObjectWithTag("ZoneBorder");
      player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {
      Translate();
      //RayBot(ref workRay);
      if (workRay)
        MoveTowards();
      else
        Translate2();
    }
    private void Translate2()
    {
      transform.Translate(Vector2.left * 1 * Time.deltaTime, Space.World);
    }
    private void Translate()
    {
      transform.Translate(Vector2.down * 2 * Time.deltaTime, Space.World);
    }
    private void MoveTowards()
    {
      transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), 0.005f);
    }
    private bool RayBot(ref bool workRay)
    {
      int bitmask = ~((1 << 7) | (1 << 6));
      float distation = Vector2.Distance(bot.transform.position, border.transform.position);
      Debug.DrawRay(bot.transform.position, bot.transform.TransformDirection(Vector2.down) * distation, Color.red);
      hitbot = Physics2D.Raycast(bot.transform.position, bot.transform.TransformDirection(Vector2.down), distation, bitmask);
      print(hitbot.distance);
      if (hitbot.distance != 0 && hitbot.collider.CompareTag("bot") & workRay == true)
      {
        print("стартбот");
        Singleton<FireBot>.Instance.StopAllCoroutines();
        workRay = false;
      }
      else if (hitbot.distance != 0 && !hitbot.collider.CompareTag("bot") & workRay == false)
      {
        print("стопбот");
        Singleton<FireBot>.Instance.BotFireOn();
        workRay = true;
      }
      return workRay;
    }
  }
}



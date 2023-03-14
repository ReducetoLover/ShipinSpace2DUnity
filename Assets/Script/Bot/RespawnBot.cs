using System.Collections;
using UnityEngine;


namespace Reducer
{
  public class RespawnBot: MonoBehaviour
  {
    [SerializeField] private GameObject Upborder;
    [SerializeField] private GameObject bot;
    [SerializeField] private int Secondsmin;
    [SerializeField] private int Secondsmax;
    [SerializeField] public int minXP;
    [SerializeField] public int maxXP;
    [SerializeField] public float Minfirebot;
    [SerializeField] public float Maxfirebot;


    void Start()
    {
      Upborder = GameObject.FindGameObjectWithTag("ZoneUp");
      StartCoroutine(TimeBot());
      
    }


    IEnumerator TimeBot()
    {
      yield return new WaitForSeconds(Random.Range(Secondsmin, Secondsmax));
      float x = Random.Range(-5f, 5f);
      Destroy(Instantiate(bot, new Vector2(x, Upborder.transform.position.y + 1f), Quaternion.identity), 15f);
      StartCoroutine(TimeBot());
    }


  }
}

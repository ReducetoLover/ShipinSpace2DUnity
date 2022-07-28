using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class RespawnBot : MonoBehaviour
  {
    public static RespawnBot instance;
    [SerializeField]
    public GameObject bot;
    [SerializeField]
    private int Secondsmin;
    [SerializeField]
    private int Secondsmax;
    [SerializeField]
    public int minXP;
    [SerializeField]
    public int maxXP;
    [SerializeField]
    public float Minfirebot;
    [SerializeField]
    public float Maxfirebot;

    void Start()
    {
      instance = this;
      StartCoroutine(TimeBot());
    }

    IEnumerator TimeBot()
    {
      yield return new WaitForSeconds(Random.Range(Secondsmin, Secondsmax));
      float x = Random.Range(-5f, 5f);
      print($"{x}+бот");
      Destroy(Instantiate(bot.gameObject, new Vector3(x, 14, 9), Quaternion.identity), 15f);
      StartCoroutine(TimeBot());
    }


  }
}

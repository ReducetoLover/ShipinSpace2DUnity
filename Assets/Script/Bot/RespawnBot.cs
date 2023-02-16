using System.Collections;
using UnityEngine;
using Unity;
using System.Threading;


namespace Reducer
{
  public class RespawnBot : MonoBehaviour
  {
    GameObject Upborder;
    public string GetCurrentFileName([System.Runtime.CompilerServices.CallerFilePath] string fileName = null)
    {
      return "\nfrom " + fileName[65..^2];
    }
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
      Upborder = GameObject.Find("Up");
      instance = this;
      StartCoroutine(TimeBot());
    }

    IEnumerator TimeBot()
    {
      yield return new WaitForSeconds(Random.Range(Secondsmin, Secondsmax));
      float x = Random.Range(-5f, 5f);
      Destroy(Instantiate(bot.gameObject, new Vector2(x, Upborder.transform.position.y+1f), Quaternion.identity), 15f);
      StartCoroutine(TimeBot());
      print($"{x}+бот,+{FromScript.instance.NameScript()}");
    }


  }
}

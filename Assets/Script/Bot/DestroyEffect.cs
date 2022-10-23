using UnityEngine;

namespace Reducer
{
  public class DestroyEffect : MonoBehaviour
  {
    //public Animation panelyoudie;
    public Animation destroybot;
    public static DestroyEffect instance;

    void Start()
    {
      instance = this;
    }
    public void Die()
    {
      print($"animate+{FromScript.instance.NameScript()}");
      //GetComponent<Animation>().Play("bot");
      destroybot.Play("bot");
    }
    //public void Panel()
    //{
    //  print("Panel");
    //  panelyoudie.Play();
    //}
    void Update()
    {

    }
  }
}

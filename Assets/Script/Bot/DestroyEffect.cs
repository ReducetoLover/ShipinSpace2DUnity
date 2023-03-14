using UnityEngine;

namespace Reducer
{
  public class DestroyEffect : MonoBehaviour
  {
    public Animation destroybot;
    public void Die()
    {
      print($"animate+{Singleton<FromScript>.Instance.NameScript()}");
      destroybot.Play("bot");
    }
  }
}

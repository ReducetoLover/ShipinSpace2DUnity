using UnityEngine;

namespace Reducer
{
  public class DestroyEffect : MonoBehaviour
  {
    [SerializeField] private Animation destroybot;
    public void Die()
    {
      destroybot.Play("bot");
    }
  }
}

using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class GameEventListener : MonoBehaviour
  {
    [SerializeField, AttentionField] private GameEvent gameEvent;
    [SerializeField] private UnityEvent Action;
    private void OnEnable()
    {
      gameEvent.RegisterListerner(this);
    }
    private void OnDisable()
    {
      gameEvent.UnregisterListerner(this);
    }
    public void InitEvent()
    {
      Action.Invoke();
    }
  }
}

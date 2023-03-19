using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class GameEventListener : MonoBehaviour
  {
    [SerializeField, AttentionField]
    private GameEvent _gameEvent;
    [SerializeField]
    private UnityEvent Action;
    private void OnEnable()
    {
      _gameEvent.RegisterListerner(this);
    }
    private void OnDisable()
    {
      _gameEvent.UnregisterListerner(this);
    }
    public void InitEvent()
    {
      Action.Invoke();
    }
  }
}

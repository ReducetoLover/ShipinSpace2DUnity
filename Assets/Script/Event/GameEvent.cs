using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
  [CreateAssetMenu(fileName = "GameEvent", menuName = "GameSo/Game Event")]
  public class GameEvent : ScriptableObject
  {
    private List<GameEventListener> _listeners = new List<GameEventListener>();
    public void RegisterListerner(GameEventListener listener)
    {
      _listeners.Add(listener);
    }
    public void UnregisterListerner(GameEventListener listener)
    {
      _listeners.Remove(listener);
    }
    public void Init()
    {
      for (int i = _listeners.Count - 1; i >= 0; i--)
      {
        _listeners[i].InitEvent();
        Debug.Log("����");
      }
    }
  }
}

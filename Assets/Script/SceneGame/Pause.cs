using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class Pause : MonoBehaviour
  {
    [SerializeField]
    private UnityEvent OnPaused;
    void Update()
    {
      if (Input.GetKey(KeyCode.Escape))
      {
        OnPaused.Invoke();
        Enable(true);
      }
    }
    public void Enable(bool value)
    {
      print(23);
      Time.timeScale = value ? 0 : 1;
    }
    private void OnApplicationPause(bool pause)
    {
      if (pause)
      {
        OnPaused.Invoke();
        Enable(true);
      }
    }
  }
}

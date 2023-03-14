using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class Pause : MonoBehaviour
  {
    [SerializeField]
    private UnityEvent OnPaused;
    void FixedUpdate()
    {
      GamePause();
    }
    public void Enable(bool value)
    {
      print($"Активания паузы+{Singleton<FromScript>.Instance.NameScript()}");
      Time.timeScale = value ? 0 : 1;
    }
    public void GamePause()
    {
      if (Input.GetKey(KeyCode.Escape))
      {
        OnPaused.Invoke();
        Enable(true);

      }
    }
    private void OnApplicationPause(bool pause)
    {
      if (pause)
      {
        if (!GameObject.Find("PanelDie"))
        {
          OnPaused.Invoke();
          Enable(true);
        }

      }
    }
  }
}


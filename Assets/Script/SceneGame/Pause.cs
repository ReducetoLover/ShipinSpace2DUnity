using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class Pause : MonoBehaviour
  {
    [SerializeField] private UnityEvent OnPaused;
    private void Update()
    {
      GamePause();
    }
    public void Enable(bool value)
    {
      Time.timeScale = value ? 0 : 1;
      if (Time.timeScale == 1)
      {
        print($"отключение паузы+{Singleton<FromScript>.Instance.NameScript()}");
      }
      else
      {
        print($"включение паузы+{Singleton<FromScript>.Instance.NameScript()}");
      }
    }
    public void GamePause()
    {
      if (Input.GetKey(KeyCode.Escape))
      {
        OnPaused.Invoke();
        print("пауза из-за нажатия ESC");
        Enable(true);

      }
    }
    private void OnApplicationPause(bool pause)
    {
      if (pause)
      {
        if (!GameObject.Find("PanelDie"))
        {
          print("пауза из-за панели смерти");
          OnPaused.Invoke();
          Enable(true);
        }
      }
    }
  }
}


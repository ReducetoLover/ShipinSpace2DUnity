using UnityEngine;

namespace Reducer
{
  public class SaveSafeArea : MonoBehaviour
  {
    [SerializeReference]
    private Camera _camera;
    private void Start()
    {
      SafeAreaData saveSafeArea = new SafeAreaData();
      saveSafeArea.SetMax(_camera.ScreenToWorldPoint(Screen.safeArea.max));
      saveSafeArea.SetMin(_camera.ScreenToWorldPoint(Screen.safeArea.min));
    }
  }
}

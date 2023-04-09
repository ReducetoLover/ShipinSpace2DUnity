using UnityEngine;

namespace Reducer
{
  public class SaveSafeArea : MonoBehaviour
  {
    [SerializeReference] private Camera cam;
    private void Start()
    {
      SafeAreaData saveSafeArea = new SafeAreaData();
      saveSafeArea.SetMax(cam.ScreenToWorldPoint(Screen.safeArea.max));
      saveSafeArea.SetMin(cam.ScreenToWorldPoint(Screen.safeArea.min));
    }
  }
}

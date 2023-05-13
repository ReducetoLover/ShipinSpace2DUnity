using UnityEngine;

namespace Reducer
{
  public class BorderVerticalPosition : MonoBehaviour
  {
    [SerializeField] private Camera cam;
    [SerializeField] private bool isUp;
    private void Awake()
    {
      SetPosition();
    }
    private void SetPosition()
    {
      Vector2 safeAreaPotion = isUp ? Screen.safeArea.max : Screen.safeArea.min;
      float positionY = cam.ScreenToWorldPoint(safeAreaPotion).y;
      if (safeAreaPotion == Screen.safeArea.min)
      {
        transform.position = new Vector2(transform.position.x, positionY);
      }
      else if (safeAreaPotion == Screen.safeArea.max)
      {
        transform.position = new Vector2(transform.position.x, positionY);
      }
    }
  }
}

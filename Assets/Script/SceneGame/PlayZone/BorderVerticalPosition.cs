using UnityEngine;

namespace Reducer
{
  public class BorderVerticalPosition : MonoBehaviour
  {
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private bool _isUp;
    private void Start()
    {
      SetPosition();
    }
    private void SetPosition()
    {
      Vector2 safeAreaPotion = _isUp ? Screen.safeArea.max : Screen.safeArea.min;
      float positionY = _camera.ScreenToWorldPoint(safeAreaPotion).y;
      if (safeAreaPotion == Screen.safeArea.min)
      {
        transform.position = new Vector2(transform.position.x, positionY - 1.2f);
      }
      else if (safeAreaPotion == Screen.safeArea.max)
      {
        transform.position = new Vector2(transform.position.x, positionY + 1.5f);
      }
    }
  }
}

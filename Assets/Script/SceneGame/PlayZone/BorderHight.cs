using UnityEngine;

namespace Reducer
{
  [RequireComponent(typeof(BoxCollider2D))]
  public class BorderHight : MonoBehaviour
  {
    [SerializeField] private Camera cam;
    private const float FullSize = 2.5f;
    private void Start()
    {
      SetSize();
    }
    private void SetSize()
    {
      float yScale = cam.ScreenToWorldPoint(Screen.safeArea.max).y * FullSize;
      BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();
      boxCollider2D.size = new Vector2(boxCollider2D.size.x, yScale);
    }
  }
}


using UnityEngine;

namespace Reducer
{
  public class PositionContent : MonoBehaviour
  {
    public GameObject canvas;

    private void Start()
    {
      gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(canvas.GetComponent<RectTransform>().sizeDelta.x, canvas.GetComponent<RectTransform>().sizeDelta.y * 1.2f);
      gameObject.GetComponent<RectTransform>().localPosition = new Vector2(transform.position.x, canvas.GetComponent<RectTransform>().sizeDelta.y * 1.1f - canvas.GetComponent<RectTransform>().sizeDelta.y);
    }
  }
}

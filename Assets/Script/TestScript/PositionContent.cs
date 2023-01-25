using UnityEngine;

namespace Reducer
{
  public class PositionContent : MonoBehaviour
  {
    public GameObject content;
    public GameObject canvas;

    private void Start()
    {
      content.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(canvas.GetComponent<RectTransform>().sizeDelta.x, canvas.GetComponent<RectTransform>().sizeDelta.y * 1.2f);
      content.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(transform.position.x, canvas.GetComponent<RectTransform>().sizeDelta.y * 1.2f - canvas.GetComponent<RectTransform>().sizeDelta.y);

    }
  }
}

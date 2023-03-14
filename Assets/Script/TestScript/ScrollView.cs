using UnityEngine;

namespace Reducer
{
  public class ScrollView : MonoBehaviour
  {
    public GameObject canvas;
    private void Start()
    {
      SizeScroll();
    }
    private void SizeScroll()
    {
      gameObject.GetComponent<RectTransform>().sizeDelta = canvas.gameObject.GetComponent<RectTransform>().sizeDelta;
    }
  }
}

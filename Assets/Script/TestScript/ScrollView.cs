using UnityEngine;

namespace Reducer
{
  public class ScrollView : MonoBehaviour
  {
    [SerializeField] private GameObject canvas;
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

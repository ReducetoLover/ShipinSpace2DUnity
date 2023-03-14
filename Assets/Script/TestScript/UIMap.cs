using UnityEngine;

namespace Reducer
{
  public class UIMap : MonoBehaviour
  {
    [SerializeField] private GameObject scroll;

    private void Start()
    {
      SizeScroll();
    }
    private void SizeScroll()
    {
      print(scroll.GetComponent<RectTransform>().sizeDelta.y / 2f);
      gameObject.GetComponent<RectTransform>().sizeDelta = scroll.gameObject.GetComponent<RectTransform>().sizeDelta;
      gameObject.GetComponent<RectTransform>().localPosition = new Vector2(0f, 0f);
      print(scroll.GetComponent<RectTransform>().sizeDelta.y);
    }

  }
}

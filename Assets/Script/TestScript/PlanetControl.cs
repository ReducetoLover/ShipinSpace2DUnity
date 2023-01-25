using UnityEngine;

namespace Reducer
{
    public class PlanetControl : MonoBehaviour
    {
    public GameObject planets;
    public GameObject canvas;

    private void Start()
    {
     
      SizeScroll();
    }
    private void SizeScroll()
    {
      planets.gameObject.GetComponent<RectTransform>().sizeDelta = canvas.gameObject.GetComponent<RectTransform>().sizeDelta/100;
      planets.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(transform.position.x, 0f);
     
    }
  }
}


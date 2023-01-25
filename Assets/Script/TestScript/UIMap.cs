using UnityEngine;

namespace Reducer
{
    public class UIMap : MonoBehaviour
    {

        public GameObject scroll;
        public GameObject canvas;

        private void Start()
        {

            SizeScroll();
        }
        private void SizeScroll()
        {

            //scroll.gameObject.GetComponent<RectTransform>().sizeDelta = canvas.gameObject.GetComponent<RectTransform>().sizeDelta;
            scroll.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(0f, -1f/canvas.GetComponent<RectTransform>().sizeDelta.y);
            scroll.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(0, canvas.GetComponent<RectTransform>().sizeDelta.y);
            print(canvas.GetComponent<RectTransform>().sizeDelta.y / 2f);
        }
    }
}

using UnityEngine;

namespace Reducer
{
    public class ScrollView : MonoBehaviour
    {
        public static ScrollView instance;
        public float size;
        public GameObject scroll;
        public GameObject canvas;

        private void Start()
        {
            instance = this;
            SizeScroll();
        }
        private void SizeScroll()
        {

            scroll.gameObject.GetComponent<RectTransform>().sizeDelta = canvas.gameObject.GetComponent<RectTransform>().sizeDelta;
           
        }
    }
}

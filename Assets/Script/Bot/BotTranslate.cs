using UnityEngine;

namespace Reducer
{
  public class BotTranslate : MonoBehaviour
  {
    public static BotTranslate instance;
    private void Start()
    {
      instance = this;//this
    }
    void Update()
    {
      //this
      transform.Translate(Vector2.down * 2 * Time.deltaTime);
    }
  }
}



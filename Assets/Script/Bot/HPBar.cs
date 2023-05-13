using UnityEngine;

namespace Reducer
{
  public class HPBar : MonoBehaviour
  {
    public SpriteRenderer sprite;
    public float width;
    private void Start()
    {
      width = sprite.size.x;
    }
  }
}

using UnityEngine;

namespace Reducer
{
  public class PLayerStartPosition : MonoBehaviour
  {
    private const float Offset = 3f;
    private void Start()
    {
      
    }
    private void SetPosition()
    {
      var positionY = new SafeAreaData().GetMin().y + Offset;
      transform.position = new Vector2(transform.position.x, positionY);
    }
  }
}

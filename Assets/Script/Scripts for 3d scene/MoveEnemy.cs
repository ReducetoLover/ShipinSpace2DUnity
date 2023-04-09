using UnityEngine;

namespace Reducer
{
  public class MoveEnemy : MonoBehaviour
  {
    private void Update()
    {
      transform.Translate(Vector3.back * 5 * Time.deltaTime);
    }
  }
}

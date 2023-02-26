using UnityEngine;

namespace Reducer
{
  public class MoveEnemy : MonoBehaviour
  {
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.back * 5 * Time.deltaTime);
    }
  }
}

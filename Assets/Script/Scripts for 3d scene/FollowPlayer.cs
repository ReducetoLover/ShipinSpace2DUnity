using UnityEngine;

namespace Reducer
{
  public class FollowPlayer : MonoBehaviour
  {
    [SerializeField] private GameObject player;
    private void Update()
    {
      transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
  }
}

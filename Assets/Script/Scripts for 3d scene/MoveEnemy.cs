using GooglePlayGames.BasicApi;
using UnityEngine;

namespace Reducer
{
  public class MoveEnemy : MonoBehaviour
  {
    [SerializeField] private GameObject player;
    private void FixedUpdate()
    {
      transform.Translate(Vector3.back * 1 * Time.deltaTime);
      transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.y, player.transform.position.x), 0.05f);
    }
  }
}

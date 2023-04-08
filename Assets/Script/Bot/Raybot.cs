using UnityEngine;

namespace Reducer
{
  public class Raybot : MonoBehaviour
  {
    [SerializeField] private GameObject targetplayer;
    [SerializeField] private float speed = 0.1f;
    private void FixedUpdate()
    {
      Positions();
    }
    public void Positions()
    {
      transform.Translate(Vector2.down * 1 * Time.deltaTime);
      transform.position = Vector2.MoveTowards(transform.position, new Vector2(targetplayer.transform.position.x, transform.position.y), speed);

    }
  }
}

using UnityEngine;
using UnityEngine.UIElements;

namespace Reducer
{
  public class EnemyMove : MonoBehaviour
  {
    private const float Speed = 2f;
    [SerializeField] private GameObject player;
    private void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
    }
    private void FixedUpdate()
    {
      transform.Translate(Vector3.down * Speed * Time.deltaTime, Space.World);
      transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), 0.005f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "ZoneDown")
      {
        print("Косунлся");
            Destroy(gameObject,1f);

      }

    }
  }
}
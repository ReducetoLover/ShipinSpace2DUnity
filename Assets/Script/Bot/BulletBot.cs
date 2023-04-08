using UnityEngine;

namespace Reducer
{
  public class BulletBot : MonoBehaviour
  {
    [SerializeField, AttentionField] private GameObject bullet;
    [SerializeField] private float speed = 5f;
    private void Update()
    {
      transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "Player")
      {
        Destroy(bullet.gameObject);
      }
      if (collision.tag == "ZoneBorder")
      {
        Destroy(bullet.gameObject);
      }

    }
  }
}

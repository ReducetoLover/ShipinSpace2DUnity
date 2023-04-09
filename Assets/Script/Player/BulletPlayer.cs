using UnityEngine;

namespace Reducer
{

  public class BulletPlayer : MonoBehaviour
  {
    [SerializeField] private GameObject bullet;
    public int damage = 1;
    [SerializeField] private float speed = 5f;
    private void Update()
    {
      transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "bot")
      {
        Destroy(bullet.gameObject);
      }
      if (collision.tag == "ZoneUp")
      {
        Destroy(bullet.gameObject, 0.2f);
      }
    }
  }
}

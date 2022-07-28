using UnityEngine;

namespace Reducer
{
  public class BulletBot : MonoBehaviour
  {
    [SerializeField,AttentionField]
    private GameObject bullet;
    public int damage = 1;
    [SerializeField]
    public float speed = 5f;
    void Update()
    {
      transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "Player")
      {
        Destroy(bullet.gameObject);
      }
    }
  }
}

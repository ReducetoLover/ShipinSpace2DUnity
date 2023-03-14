using UnityEngine;

namespace Reducer
{

  public class BulletPlayer : MonoBehaviour
  {
    [SerializeField]
    public GameObject bullet;
    public int damage = 1;
    [SerializeField]
    public float speed = 5f;
    SafeAreaData saveSafeArea = new SafeAreaData();
    public Vector2 min;
    Vector2 max;

    // Start is called before the first frame update
    void Start()
    {
      //min = Camera.main.ViewportToWorldPoint(Screen.safeArea.max);
      //max = Camera.main.ViewportToWorldPoint(Screen.safeArea.min);
    }

    // Update is called once per frame
    public void Update()
    {
      transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "bot")
      {
        Destroy(bullet.gameObject);
      }
      if (collision.tag == "ZoneBorder")
      {
        Destroy(bullet.gameObject,0.2f);
      }
    }
  }
}

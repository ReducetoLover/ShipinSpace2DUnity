using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  [RequireComponent(typeof(Rigidbody2D))]
  public class PlayerMove : MonoBehaviour
  {
    [SerializeField] private DynamicJoystick joystick;
    [SerializeField] private Rigidbody2D rigidbody2d;
    [SerializeField] private UnityEvent PlayerDie;
    [SerializeField] private Pause pause;
    private float speed = 6f;
    private Vector2 direction = Vector2.zero;
    private void FixedUpdate()
    {
      if (joystick.Horizontal != 0 || joystick.Vertical != 0)
      {
        direction.x = joystick.Horizontal;
        direction.y = joystick.Vertical;
        rigidbody2d.MovePosition(rigidbody2d.position + speed * Time.fixedDeltaTime * direction);
      }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "bot" || collision.tag == "bulletbot")
      {
        PlayerDie.Invoke();
      }
    }

  }
}

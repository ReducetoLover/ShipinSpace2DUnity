using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class Move : MonoBehaviour
  {
    private Vector3 _direction = Vector3.zero;
    [SerializeField] private DynamicJoystick joystick;
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private UnityEvent PlayerDie;
    private float _speed = 3f;
    private void FixedUpdate()
    {
      if (joystick.Horizontal != 0 || joystick.Vertical != 0)
      {
        _direction.x = joystick.Horizontal;
        _direction.z = joystick.Vertical;
        rigidBody.MovePosition(rigidBody.position + _speed * Time.fixedDeltaTime * _direction);
      }
    }
    private void OnTriggerEnter(Collider collision)
    {
      if (collision.tag == "bot" || collision.tag == "bulletbot")
      {
        PlayerDie.Invoke();
      }
    }
  }
}

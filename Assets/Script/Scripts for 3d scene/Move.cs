using UnityEngine;

namespace Reducer
{
  public class Move : MonoBehaviour
  {
    private Vector3 _direction = Vector3.zero;
    [SerializeField] private DynamicJoystick joystick;
    [SerializeField] private Rigidbody rigidBody;
    private float _speed = 1f;
    private void Awake()
    {
      rigidBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
      if (joystick.Horizontal != 0 || joystick.Vertical != 0)
      {
        _direction.x = joystick.Horizontal;
        rigidBody.MovePosition(rigidBody.position + _speed * Time.fixedDeltaTime * _direction);
      }
    }
  }
}

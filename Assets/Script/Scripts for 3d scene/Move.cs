using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
    public class Move : MonoBehaviour
    {
      private Vector3 _direction = Vector3.zero;
      [SerializeField]private DynamicJoystick _joystick;
    [SerializeField]private Rigidbody _rigidBody;
    private float _speed = 4f;
    // Start is called before the first frame update
    private void Awake()
    {

      _rigidBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
      if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
      {
        _direction.x = _joystick.Horizontal;
        //_direction.y = _joystick.Vertical;
        _rigidBody.MovePosition(_rigidBody.position + _speed * Time.fixedDeltaTime * _direction);
      }
    }
  }
}

using UnityEngine;
using TMPro;

namespace Reducer
{
  [RequireComponent(typeof(Rigidbody2D))]
  public class PlayerMove : MonoBehaviour
  {
    [SerializeField]
    private DynamicJoystick _joystick;
    private int Diescore;
    private Rigidbody2D _rigidbody2D;
    public GameObject paneldie;
    public TextMeshProUGUI paneldietext;
    public Pause pause;
    private float _speed = 4f;
    private Vector2 _direction = Vector2.zero;

    private void Awake()
    {
     
      _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
      Diescore = PlayerPrefs.GetInt("Diescore");
    }
    private void FixedUpdate()
    {
      if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
      {
        _direction.x = _joystick.Horizontal;
        _direction.y = _joystick.Vertical;
        _rigidbody2D.MovePosition(_rigidbody2D.position + _speed * Time.fixedDeltaTime * _direction);
      }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "bot" || collision.tag == "bulletbot")
      {
        paneldie.SetActive(true);
        Diescore += 1;
        PlayerPrefs.SetInt("Diescore",Diescore);
        paneldietext.text = ($"YOU DIE x{PlayerPrefs.GetInt("Diescore")}");
        pause.Enable(true);
      }
    }
  }
}

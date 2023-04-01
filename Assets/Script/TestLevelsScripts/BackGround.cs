using UnityEngine;

namespace Reducer
{
  public class BackGround : MonoBehaviour
  {
    [SerializeField] private GameObject[] _sprite;
    [SerializeField] private float _speed = 2.5f;
    private float _positionMinY;
    private Vector2 _restartPosition;
    private void Start()
    {
      _sprite = GameObject.FindGameObjectsWithTag("Sky");
      for (int i = 0; i < _sprite.Length; i++)
      {
        _sprite[i].GetComponent<SpriteRenderer>().color = Color.red;
        //_sprite[i].transform.position = new Vector3(0, -25.6f + i * 12.8f, 0);
      }
      _restartPosition = transform.position;
      _positionMinY = _sprite[0].GetComponent<SpriteRenderer>().size.y - _restartPosition.y;// две высоты спрайта - начальная позиция по Y
    }

    private void Awake()
    {
     
    }
    private void Update()
    {
      transform.Translate(Vector3.down * _speed * Time.deltaTime);
      if (transform.position.y <= -_positionMinY)
      {
        transform.position = _restartPosition;
      }
    }
  }
}

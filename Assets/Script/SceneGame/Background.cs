using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
  public class Background : MonoBehaviour
  {
    [SerializeField]
    private SpriteRenderer _sprite;
    public float _speed = 2.5f;
    private float _positionMinY;
    private Vector2 _restartPosition;
    private void Awake()
    {
      _restartPosition = transform.position;
      _positionMinY = _sprite.bounds.size.y * 2 - _restartPosition.y;// две высоты спрайта - начальная позиция по Y
    }
    private void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
      if (transform.position.y<=-_positionMinY)
      {
        transform.position = _restartPosition;
      }
      

    }
  } 
}

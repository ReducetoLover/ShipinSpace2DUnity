using UnityEngine;

namespace Reducer
{
  public class Background : MonoBehaviour
  {
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private float speed = 2.5f;
    private float positionMinY;
    private Vector2 restartPosition;
    private void Awake()
    {
      restartPosition = transform.position;
      positionMinY = sprite.bounds.size.y*2 - restartPosition.y;// ���� ������ ������� - ��������� ������� �� Y
    }
    private void Update()
    {
      transform.Translate(Vector3.down * speed * Time.deltaTime);
      if (transform.position.y <= -positionMinY)
      {
        transform.position = restartPosition;
      }
    }
  }
}

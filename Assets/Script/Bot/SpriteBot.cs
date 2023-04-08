using UnityEngine;

namespace Reducer
{
  public class SpriteBot : MonoBehaviour
  {
    [SerializeField] private Sprite[] sprites;
    void Awake()
    {
      gameObject.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
    }
  }

}

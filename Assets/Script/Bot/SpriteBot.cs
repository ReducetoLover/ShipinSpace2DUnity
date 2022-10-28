using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
    public class SpriteBot : MonoBehaviour
    {
      [SerializeField] private Sprite[] sprites;
    private void Start()
    {
      
    }
    void Awake()
    {
      gameObject.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
    }
  }

}

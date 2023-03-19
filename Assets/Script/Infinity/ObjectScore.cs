using System;
using UnityEngine;

namespace Reducer
{
  public class ObjectScore : MonoBehaviour
  {
    public static event Action<int> OnChanged;
    [SerializeField, Range(10,500)] private int score=100;
    public void Activate()
    {
      OnChanged?.Invoke(score);
    }
  }
}

using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class PointGenerator : MonoBehaviour
  {
    [SerializeField]
    private UnityEvent OnGenerated;
    private void Start()
    {
      OnGenerated.Invoke();
    }
  }
}

using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class PointGenerator : MonoBehaviour
  {
    
    [SerializeField]
    private UnityEvent OnGenerated;// окончание генерации
    private void Start()
    {
      OnGenerated.Invoke();
    }
  }

}

using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class PointGenerator : MonoBehaviour
  {
    [SerializeField]
    private MapPoint _pointLayable;//играбельный уровень
    [SerializeField]
    private GameObject _pointLocked;//заблокированный уровень
    [SerializeField]
    private UnityEvent OnGenerated;// окончание генерации
    private void Start()
    {
      OnGenerated.Invoke();
    }
  }

}

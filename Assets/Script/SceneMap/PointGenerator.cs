using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class PointGenerator : MonoBehaviour
  {
    [SerializeField]
    private MapPoint _pointLayable;//����������� �������
    [SerializeField]
    private GameObject _pointLocked;//��������������� �������
    [SerializeField]
    private UnityEvent OnGenerated;// ��������� ���������
    private void Start()
    {
      OnGenerated.Invoke();
    }
  }

}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Reducer
{
  [RequireComponent(typeof(CircleCollider2D))]
  public class MapPoint : MonoBehaviour, IPointerClickHandler
  {
    [SerializeField] private GameObject CurrentLevel;
    [SerializeField] private string levelUnLock;
    [SerializeField] private new string name;
    [SerializeField] private int _text = 0;
    [SerializeField] private UnityEvent OnClick;
    private int _index;
    public void SetParameters()
    {
      // _index = Convert.ToInt32(_text.text);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
      PlayerPrefs.SetInt("indexlvl", _text);
      PlayerPrefs.SetString("CurrentLevel", CurrentLevel.name);
      PlayerPrefs.Save();
      LevelNameData level = new LevelNameData();
      level.Setname($"{name}");
      //level.SetLevelIndex(_index);
      OnClick.Invoke();
    }
  }
}

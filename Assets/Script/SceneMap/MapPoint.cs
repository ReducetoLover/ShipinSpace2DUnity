using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Reducer
{
  [RequireComponent(typeof(CircleCollider2D))]
  public class MapPoint : MonoBehaviour, IPointerClickHandler
  {
    string levelUnLock;
    public new string name;
    [SerializeField]
    private TextMeshPro _text;
    [SerializeField]
    private UnityEvent OnClick;
    private int _index;
    public void SetParameters(Sprite sprite, int index)
    {
      GetComponent<SpriteRenderer>().sprite = sprite;
      _index = index;
      _text.text = _index.ToString();
    }
    void Start()
    {
      //PlayerPrefs.DeleteKey("levels");
      levelUnLock = PlayerPrefs.GetString("levels", "Level1");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
      LevelNameData level = new LevelNameData();
      level.Setname($"{name}");
      level.SetLevelIndex(_index);
      OnClick.Invoke();

    }

  }
}

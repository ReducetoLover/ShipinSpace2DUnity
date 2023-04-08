using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;
using static Reducer.Loader;

namespace Reducer
{
  [RequireComponent(typeof(CircleCollider2D))]
  public class MapPoint : MonoBehaviour, IPointerClickHandler
  {
    [SerializeField] private GameObject CurrentLevel;
    string levelUnLock;
    public new string name;
    [SerializeField]
    private int _text=0;
    [SerializeField]
    private UnityEvent OnClick;
    private int _index;
    public void SetParameters()
    {
     // _index = Convert.ToInt32(_text.text);
     
    }
    void Start()
    {
      //levelUnLock = PlayerPrefs.GetString("levels", "Level1");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
      PlayerPrefs.SetInt("indexlvl", _text);
     PlayerPrefs.SetString("CurrentLevel",CurrentLevel.name);
      PlayerPrefs.Save();
      LevelNameData level = new LevelNameData();
      level.Setname($"{name}");
     //level.SetLevelIndex(_index);
      OnClick.Invoke();

    }

  }
}

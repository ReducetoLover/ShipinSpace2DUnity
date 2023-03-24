using TMPro;
using UnityEngine;

namespace Reducer
{
  public class DieInLevel : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI paneldietext;
    [SerializeField] private int Diescore;
    private void Start()
    {
      Diescore = PlayerPrefs.GetInt("Diescore");
    }
    public void Playerisdeadonlevel()
    {
      Diescore += 1;
      PlayerPrefs.SetInt("Diescore", Diescore);
      paneldietext.text = ($"YOU DIE x{PlayerPrefs.GetInt("Diescore")}");
    }
  }
}

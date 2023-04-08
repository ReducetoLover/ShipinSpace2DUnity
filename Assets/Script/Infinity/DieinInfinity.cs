using System;
using TMPro;
using UnityEngine;

namespace Reducer
{
  public class DieinInfinity : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI textDie;
    [SerializeField] private TextMeshProUGUI textUI;
    [SerializeField] private TextMeshProUGUI textRecord;
    public GoogleServices googleServices;
    public void Die()
    {
      
      textDie.text = $"{textUI.text} score";
      textRecord.text = $"Record {SaveToPlayerPrefs.RecordInfinity(textUI.text)} score";
      googleServices.SaveTableRecord(PlayerPrefs.GetInt("scorerecord"));

    }
  }
}

using TMPro;
using UnityEngine;

namespace Reducer
{
  public class Diein3D : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI textDie;
    [SerializeField] private TextMeshProUGUI textUI;
    [SerializeField] private TextMeshProUGUI textRecord;
    public GoogleServices googleServices;
    public void Die()
    {
      textDie.text = $"{textUI.text} seconds";
      textRecord.text = $"Record {SaveToPlayerPrefs.Record3D(textUI.text)} seconds";
      googleServices.SaveTableRecord3D(PlayerPrefs.GetInt("secondsrecord"));

    }
  }
}

using TMPro;
using UnityEngine;

namespace Reducer
{
  public class UIScore : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI text;
    public void ShowValue(int value)
    {
      text.text = value.ToString();
    }
  }
}

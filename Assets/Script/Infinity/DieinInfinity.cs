using TMPro;
using UnityEngine;

namespace Reducer
{
  public class DieinInfinity : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI textDie;
    [SerializeField] private TextMeshProUGUI textUI;
    public void Die()
    {
      textDie.text = ($"{textUI.text} score") ;
    }
  }
}

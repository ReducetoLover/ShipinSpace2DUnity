using TMPro;
using UnityEngine;

namespace Reducer
{
  public class ToggleMenu : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI Automate;
    [SerializeField] private TextMeshProUGUI Button;
    [SerializeField] private string Choice;

    void Awake()
    {
      Choice = PlayerPrefs.GetString("ChoiceControl");
      if (Choice == "button")
      {
        Button.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
        Automate.fontStyle &= FontStyles.SmallCaps;
      }
      else if (Choice == "automate")
      {
        Automate.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
        Button.fontStyle &= FontStyles.SmallCaps;
      }
      else
      {
        Automate.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
        Button.fontStyle &= FontStyles.SmallCaps;
      }
      print($"{Choice}+{Singleton<FromScript>.Instance.NameScript()} При старте");
    }
    public void PutButton()
    {
      Choice = "button";
      print($"{Choice}+{Singleton<FromScript>.Instance.NameScript()} При нажатии");
      PlayerPrefs.SetString("ToggleMenu", Choice);
      PlayerPrefs.Save();
      Button.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
      Automate.fontStyle &= FontStyles.SmallCaps;
    }
    public void PutAutomate()
    {
      Choice = "automate";
      print($"{Choice}+{Singleton<FromScript>.Instance.NameScript()} При нажатии");
      PlayerPrefs.SetString("ChoiceControl", Choice);
      PlayerPrefs.Save();
      Automate.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
      Button.fontStyle &= FontStyles.SmallCaps;
    }
  }
}

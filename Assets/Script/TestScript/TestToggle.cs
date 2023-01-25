using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Reducer
{
  public class TestToggle : MonoBehaviour
  {
    public TextMeshProUGUI Automate;
    public TextMeshProUGUI Button;
    public string Choice;
    public static TestToggle instance;

    void Awake()
    {
      instance = this;
      Choice = PlayerPrefs.GetString("ChoiceControl");
      if (Choice=="button")
      {
        Button.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
        Automate.fontStyle &= FontStyles.SmallCaps;
      }
      else
      {
        Automate.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
        Button.fontStyle &= FontStyles.SmallCaps;
      }
      print($"{Choice}+{FromScript.instance.NameScript()} При старте");
    }
    void Update()
    {

    }

    public void PutButton()
    {
      Choice = "button";
      print($"{Choice}+{FromScript.instance.NameScript()} При нажатии");
      PlayerPrefs.SetString("ChoiceControl", Choice);
      PlayerPrefs.Save();
      Button.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
      Automate.fontStyle &= FontStyles.SmallCaps;
    }
    public void PutAutomate()
    {
      Choice = "automate";
      print($"{Choice}+{FromScript.instance.NameScript()} При нажатии");
      PlayerPrefs.SetString("ChoiceControl", Choice);
      PlayerPrefs.Save();
      Automate.fontStyle = FontStyles.SmallCaps | FontStyles.Underline | FontStyles.Italic;
      Button.fontStyle &= FontStyles.SmallCaps;
    }
  }
}

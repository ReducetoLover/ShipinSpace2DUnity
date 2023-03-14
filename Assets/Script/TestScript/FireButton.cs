using UnityEngine;
using UnityEngine.UI;

namespace Reducer
{
  public class FireButton : MonoBehaviour
  {
    [SerializeField] private GameObject Fire;
    [SerializeField] private GameObject Player;
    private void Start()
    {
      if (PlayerPrefs.GetString("ChoiceControl") == "button")
      {
        PlayAutomate();
      }
      else
      {
        PlayButton();
      }
    }
    public void PlayAutomate()
    {
      print($"Автоматический режим управления {Singleton<FromScript>.Instance.NameScript()}");
      Player = GameObject.Find("Player");
      Fire = GameObject.Find("Fire");
      Player.GetComponent<RayPlayer>().enabled = false;
      Fire.GetComponent<Image>().enabled = true;
    }
    public void PlayButton()
    {
      print($"Ручной режим управления {Singleton<FromScript>.Instance.NameScript()}");
      Player = GameObject.Find("Player");
      Fire = GameObject.Find("Fire");
      Player.GetComponent<RayPlayer>().enabled = true;
      Fire.GetComponent<Image>().enabled = false;
    }
  }
}


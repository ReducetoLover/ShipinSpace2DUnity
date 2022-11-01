using UnityEngine;

namespace Reducer
{
  public class FireButton : MonoBehaviour
  {
    public static FireButton instance;
    private int Choice;
    public GameObject Fire;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
      
      instance = this;
      Choice = PlayerPrefs.GetInt("Choice");
      print($"{Choice}+{FromScript.instance.NameScript()}");
      if (Choice == 1)
      {
        print("Зашёл на 1");
        Player = GameObject.Find("Player");
        Player.GetComponent<RayPlayer>().enabled = false;
        Fire.SetActive(true);

      }
      else
      {
        print("Зашёл на 0");
        Player = GameObject.Find("Player");
        Player.GetComponent<RayPlayer>().enabled = true;
        Fire.SetActive(false);
      }
    }
    public void Put()
    {
      if (Choice == 1)
        Choice = 0;
      else
        Choice = 1;
      print($"{Choice}+{FromScript.instance.NameScript()}");
      PlayerPrefs.SetInt("Choice", Choice);
      PlayerPrefs.Save();
    }
  }
}


using UnityEngine;

namespace Reducer
{
  public class FireButton : MonoBehaviour
  {
    public static FireButton instance;
    public int Choice;
    public GameObject Fire;

    // Start is called before the first frame update
    void Start()
    {
      instance = this;
      Choice = PlayerPrefs.GetInt("Choice");

      print($"{Choice}+{FromScript.instance.NameScript()}");
      if (Choice == 1)
      {
        Fire.SetActive(true);
      }
      else
        Fire.SetActive(false);
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


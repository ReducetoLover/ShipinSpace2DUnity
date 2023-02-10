using UnityEngine;

namespace Reducer
{
  public class LevelSave : MonoBehaviour
  {
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level2lock;
    public GameObject Level3lock;
    public GameObject Level4lock;
    public GameObject Level5lock;
    public int Unlocklevel = 0;
    // Start is called before the first frame update
    void Start()
    {

      Unlocklevel = PlayerPrefs.GetInt("levels");
      print($"{ Unlocklevel}");
      switch (Unlocklevel)
      {
        case 2:
          Level2.GetComponent<MapPoint>().enabled = true;
          Level2lock.SetActive(false);
          break;
        case 3:
          Level2.GetComponent<MapPoint>().enabled = true;
          Level2lock.SetActive(false);
          Level3.GetComponent<MapPoint>().enabled = true;
          Level3lock.SetActive(false);
          break;
        case 4:
          Level2.GetComponent<MapPoint>().enabled = true;
          Level2lock.SetActive(false);
          Level3.GetComponent<MapPoint>().enabled = true;
          Level3lock.SetActive(false);
          Level4.GetComponent<MapPoint>().enabled = true;
          Level4lock.SetActive(false);
          break;
        case 5:
          Level2.GetComponent<MapPoint>().enabled = true;
          Level2lock.SetActive(false);
          Level3.GetComponent<MapPoint>().enabled = true;
          Level3lock.SetActive(false);
          Level4.GetComponent<MapPoint>().enabled = true;
          Level4lock.SetActive(false);
          Level5.GetComponent<MapPoint>().enabled = true;
          Level5lock.SetActive(false);
          break;
        default:
          break;

      }
    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}

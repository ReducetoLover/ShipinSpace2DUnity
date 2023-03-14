using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public class LevelSave : MonoBehaviour
  {
    public GameObject Level2lock;
    public GameObject Level3lock;
    public GameObject Level4lock;
    public GameObject Level5lock;
    public GameObject Level6lock;
    //[SerializeField] private Dictionary<GameObject,int> LevelsLock = new Dictionary<GameObject,int>();
    [SerializeField] private int Unlocklevel= 2;

    private void Start()
    {
      
      UnlockLevelsInMap();
    }

    public void UnlockLevelsInMap()
    {
      Unlocklevel = PlayerPrefs.GetInt("levels");
      print($"{Unlocklevel} уровень открыт");
      switch (Unlocklevel)
      {
        case 1:
          break;
        case 2:
          Level2lock.SetActive(false);
          break;
        case 3:
          Level2lock.SetActive(false);
          Level3lock.SetActive(false);
          break;
        case 4:
          Level2lock.SetActive(false);
          Level3lock.SetActive(false);
          Level4lock.SetActive(false);
          break;
        case 5:
          Level2lock.SetActive(false);
          Level3lock.SetActive(false);
          Level4lock.SetActive(false);
          Level5lock.SetActive(false);
          break;
        case 6:
          Level2lock.SetActive(false);
          Level3lock.SetActive(false);
          Level4lock.SetActive(false);
          Level5lock.SetActive(false);
          Level6lock.SetActive(false);
          break;
        default:
          Level2lock.SetActive(false);
          Level3lock.SetActive(false);
          Level4lock.SetActive(false);
          Level5lock.SetActive(false);
          Level6lock.SetActive(false);
          break;
      }
    }
  }
}

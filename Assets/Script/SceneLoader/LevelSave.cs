using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public class LevelSave : MonoBehaviour
  {
    public static LevelSave instance;
    public GameObject Level2lock;
    public GameObject Level3lock;
    public GameObject Level4lock;
    public GameObject Level5lock;
    //[SerializeField] private Dictionary<GameObject,int> LevelsLock = new Dictionary<GameObject,int>();
    [SerializeField] private int Unlocklevel= 2;
    private void Awake()
    {
      instance = this;
    }
    private void Start()
    {
      
      UnlockLevelsInMap();
    }
    public void SaveInPlayerPrefs()
    {
      

      if (SceneManager.GetActiveScene().buildIndex + 1 > PlayerPrefs.GetInt("levels"))
      {
        PlayerPrefs.SetInt("levels", SceneManager.GetActiveScene().buildIndex + 1);
      }
    }
    public void UnlockLevelsInMap()
    {
      Unlocklevel = PlayerPrefs.GetInt("levels");
      print($"{Unlocklevel} уровень открыт");
      switch (Unlocklevel)
      {
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
        default:
          break;
      }
    }
  }
}

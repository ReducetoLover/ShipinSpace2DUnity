using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Reducer
{
  public class LevelSave : MonoBehaviour
  {
    [SerializeField] private GameObject[] LockLevels;
    [SerializeField] private int Unlocklevel=0;

    private void Start()
    {
      LockLevels = GameObject.FindGameObjectsWithTag("Planet");
      UnlockLevelsInMap();

    }
    public void UnlockLevelsInMap()
    {
      Unlocklevel = PlayerPrefs.GetInt("levels");
      for (int i = 0;  LockLevels.Length > i & i < Unlocklevel; i++)
      {
        LockLevels[i].SetActive(false);
      }
    }
  }
}

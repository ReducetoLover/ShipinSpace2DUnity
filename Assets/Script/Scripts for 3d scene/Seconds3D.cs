using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Reducer
{
  public class Seconds3D : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI textUI;
    private int seconds = 0;
    void Start()
    {
      StartCoroutine(Sec3D());
    }
    IEnumerator Sec3D()
    {
      yield return new WaitForSeconds(1f);
      seconds++;
      textUI.text = seconds.ToString()+"s";
      StartCoroutine(Sec3D());
    }

  }
}

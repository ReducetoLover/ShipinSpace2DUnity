using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Reducer
{
    public class ButtonTest : MonoBehaviour
    {
    private Loader loader;
    [SerializeField] private Button button;
    private void OnEnable()
    {
      button.onClick.AddListener(loader.Load);
    }
    private void OnDisable()
    {
      button.onClick.RemoveListener(loader.Load);
    }
  }
}

using System.Collections.Generic;
using UnityEngine;
using System;

namespace Reducer
{
    [Serializable]
    public class PointStates
    {
      public List<PointState> States = new List<PointState>();
    }
    [Serializable]
    public enum PointState
    {
      Locked,
      Unlocked
    }
  
}

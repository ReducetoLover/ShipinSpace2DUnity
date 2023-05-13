using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
  [CreateAssetMenu(fileName = "3DLevel", menuName = "GameSo/3D")]
  public class ThreeDSettings : ScriptableObject
    {
    public GameObject player;
    public GameObject bot;
    [Range(1, 100)]
    [Header("Settings bot")]
    public int MinXP;
    [Range(1, 100)]
    public int MaxXP;
    [Range(1, 100)]
    public float MinRespawnbot;
    [Range(1, 100)]
    public float MaxRespawnbot;
    [Range(1, 100)]
    public float MinFirebot;
    [Range(1, 100)]
    public float MaxFirebot;
    [Header("Settings achive")]
    [Range(0, 300)]
    public int Time;
    [Range(0, 100)]
    public int Kill;
  }
}

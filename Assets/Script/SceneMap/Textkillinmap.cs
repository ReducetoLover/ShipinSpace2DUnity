using TMPro;
using UnityEngine;
using System;
namespace Reducer
{
  public class Textkillinmap : MonoBehaviour
  {
    public static Textkillinmap instance;
    [SerializeField]
    public TextMeshProUGUI killtxt;
    public TextMeshProUGUI dietxt;
    private int kill;
    // Start is called before the first frame update
    private void Awake()
    {
      
    }
    void Start()
    {
      
      instance = this;
      dietxt.text = ($"{PlayerPrefs.GetInt("Diescore")} died");
      killtxt.text = ($"{PlayerPrefs.GetInt("kill")} destroyed");
      print($"{kill}+ {killtxt.text}");
    }

    public void Scorekillbot()
    {
      kill = PlayerPrefs.GetInt("kill");
      print($"���������+{FromScript.instance.NameScript()}");
      kill += 1;
      PlayerPrefs.SetInt("kill", kill);
    }
    // Update is called once per frame
    void Update()
    {

    }
  }
}

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
      instance = this;
    }
    void Start()
    {
      
      
      dietxt.text = ($"{PlayerPrefs.GetInt("Diescore")} died");
      killtxt.text = ($"{PlayerPrefs.GetInt("kill")} destroyed");
      print($"{kill}+ {killtxt.text}");
    }

    public void Scorekillbot()
    {
      print($"засчитало+{FromScript.instance.NameScript()}");
      PlayerPrefs.SetInt("kill", PlayerPrefs.GetInt("kill")+1);
    }
    // Update is called once per frame
    void Update()
    {

    }
  }
}

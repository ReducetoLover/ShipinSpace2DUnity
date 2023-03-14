using TMPro;
using UnityEngine;
namespace Reducer
{
  public class Textkillinmap : MonoBehaviour
  {
    //public static Textkillinmap instance;
    [SerializeField] private TextMeshProUGUI killtxt;
    [SerializeField] private TextMeshProUGUI dietxt;
    private int kill;
    private void Awake()
    {
      //instance = this;
    }
    private void Start()
    {
      dietxt.text = ($"{PlayerPrefs.GetInt("Diescore")} died");
      killtxt.text = ($"{PlayerPrefs.GetInt("kill")} destroyed");
      print($"{kill}+ {killtxt.text}");
    }
  }
}

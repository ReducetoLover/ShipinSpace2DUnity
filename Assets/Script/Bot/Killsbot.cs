using TMPro;
using UnityEngine;

namespace Reducer
{
  public class Killsbot : MonoBehaviour
  {
    public GameObject kill;
    public BotTranslate Bot;
    [SerializeField] public TextMeshProUGUI killText;
    [SerializeField] public int wantkill = 5;
    public Pause pause;
    public GameObject panelwin;
    public int nowkill = 0;
    public bool _pause = false;

    void Start()
    {
      _pause = true;
      killText.transform.position = new Vector3(-4.5f, 10f, 9);
      kill.transform.position = new Vector3(-6f, 10f, 9);
    }
    void Update()
    {
      if (_pause)
      {
        Kill();
        if (GameObject.Find("AchiveTime") == false)
        {
          _pause = false;
          panelwin.SetActive(true);
          pause.Enable(true);
        }
        else if (GameObject.Find("AchiveTime") == true && Singleton<Timer>.Instance._timerOn == false)
        {
          _pause = false;
          panelwin.SetActive(true);
          pause.Enable(true);
        }
      }
    }
    public void Kill()
    {
      killText.text = ($"{nowkill}/{wantkill}");
    }

  }
}

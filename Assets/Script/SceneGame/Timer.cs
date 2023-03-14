using TMPro;
using UnityEngine;

namespace Reducer
{
  public class Timer : MonoBehaviour
  {
    [SerializeField] public float time = 30f;
    [SerializeField] private GameObject sand_Time;
    [SerializeField] private TextMeshProUGUI timerText;

    public float _timeLeft = 0f;
    public bool _timerOn = false;
    public Pause pause;
    public GameObject panelwin;

    private void Start()
    {
      sand_Time.transform.position = new Vector3(-5.7f, 12f, 9);
      timerText.transform.position = new Vector3(-4.5f, 12f, 9);
      _timeLeft = 0f;
      _timerOn = true;
    }

    private void Update()
    {
      if (_timerOn)
      {
        if (_timeLeft < time)
        {
          _timeLeft += Time.deltaTime;
          UpdateTimeText();
        }
        else
        {
          if (GameObject.Find("Achivekills") == false)
          {
            _timeLeft = time;
            _timerOn = false;
            panelwin.SetActive(true);
            pause.Enable(true);
          }
          else if (GameObject.Find("Achivekills") == true && Singleton<Killsbot>.Instance.wantkill == Singleton<Killsbot>.Instance.nowkill)
          {
            _timeLeft = time;
            _timerOn = false;
            panelwin.SetActive(true);
            pause.Enable(true);
          }
        }
      }
    }

    public void UpdateTimeText()
    {
      if (_timeLeft < 0)
        _timeLeft = 0;

      float minutes = Mathf.FloorToInt(_timeLeft / 60);
      float seconds = Mathf.FloorToInt(_timeLeft % 60);
      timerText.text = ($"{seconds}/{time}");
    }
  }
}

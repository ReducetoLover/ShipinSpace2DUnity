using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Reducer
{
  public class AchiveControl : MonoBehaviour
  {
    public int SaveLevel = 0;
    public static AchiveControl instance;
    [SerializeField] public float time = 30f;
    public GameObject Timeimage;
    public TextMeshProUGUI timerText;
    public GameObject Killimage;
    public TextMeshProUGUI Textkills;
    public GameObject panelwin;
    public Pause pause;
    public float _timeLeft;
    private bool toggle = false;
    private bool _timerOn = false;
    private bool workkill = false;
    [SerializeField] public int wantkill = 5;
    public int nowkill = 0;
    public bool achiveKills = true;
    public bool achiveTime = true;
    private void Start()
    {
      _timeLeft = 0f;
      toggle = true;
      instance = this;
      print("Start");
      if (GameObject.Find("AchiveKill"))
      {
        workkill = true;
        achiveKills = true;
      }
      else
      {
        workkill = false;
        achiveKills = false;
      }
      if (GameObject.Find("AchiveTime"))
      {
        _timerOn = true;
        achiveTime = true;
      }
      else
      {
        _timerOn = false;
        achiveTime = false;
      }
    }


    public void Update()
    {
      if (Time.timeScale == 1)
      {
        if (toggle)
        {
          if (_timerOn! || workkill)
          {
            if (achiveTime == true && achiveKills == true)
            {
              _Time();
              _Kill();
            }
            else if (!achiveTime && achiveKills)
            {
              _Kill();
            }
            else if (achiveTime && !achiveKills)
            {
              _Time();
            }
          }
          else
          {
            SaveLevel = SceneManager.GetActiveScene().buildIndex + 1;
            print($"{SaveLevel} + {PlayerPrefs.GetInt("levels")}+{FromScript.instance.NameScript()}");
            if (SaveLevel > PlayerPrefs.GetInt("levels"))
            {
              PlayerPrefs.SetInt("levels", SaveLevel);
            }
            print($"{PlayerPrefs.GetInt("levels")} ага+{FromScript.instance.NameScript()}");
            toggle = false;
            panelwin.SetActive(true);
            pause.Enable(true);
          }
        }
      }

    }
    public void _Time()
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
          _timeLeft = time;
          _timerOn = false;
          print($"{time} +{FromScript.instance.NameScript()}");
        }


      }
    }
    public void _Kill()
    {
      if (workkill)
      {
        Kill();
        if (nowkill == wantkill)
        {
          workkill = false;
        }

      }
    }

    public void CountKills() //
    {
      if (nowkill < wantkill)
      {
        nowkill++;
      }

    }
    public void Kill()//обновление счётчика килов
    {
      Textkills.text = ($"{nowkill}/{wantkill}");
      Console.WriteLine(76876);
    }

    public void UpdateTimeText()//обновление таймера
    {
      if (_timeLeft < 0)
        _timeLeft = 0;

      float minutes = Mathf.FloorToInt(_timeLeft / 60);
      float seconds = Mathf.FloorToInt(_timeLeft % 180);
      timerText.text = ($"{seconds}/{time}");
    }
  }
}

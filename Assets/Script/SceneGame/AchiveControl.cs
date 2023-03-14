using System;
using TMPro;
using UnityEngine;

namespace Reducer
{
  public class AchiveControl : MonoBehaviour
  {
    public int SaveLevel = 0;
    [SerializeField] private float time = 30f;
    [SerializeField] private GameObject Timeimage;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject Killimage;
    [SerializeField] private TextMeshProUGUI Textkills;
    [SerializeField] private GameObject panelwin;
    public Pause pause;
    public float _timeLeft;
    private bool toggle;
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
      SearchAchiveTime();
    }
    public void SearchAchiveTime()
    {
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
          if (_timerOn !|| workkill)
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
            else
            {
              Infinity();
            }
          }
          else
          {
            Singleton<SaveToPlayerPrefs>.Instance.SaveLevel(); //LevelSave.instance.SaveInPlayerPrefs();
            toggle = false;
            panelwin.SetActive(true);
            pause.Enable(true);
          }
        }
      }

    }
    public void _Time() //включение/выключение запуска времени  
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
          print($"{time} +{Singleton<FromScript>.Instance.NameScript()}");
        }


      }
    }
    public void _Kill() //включение/выключение посчёта килов
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
    public void Infinity()
    {

    }
    public void CountKills() //подсчёт килов
    {
      if (nowkill < wantkill)
      {
        nowkill++;
      }

    }
    public void Kill()//обновление счётчика килов
    {
      Textkills.text = ($"{nowkill}/{wantkill}");
    }

    public void UpdateTimeText()//обновление таймера
    {
      if (_timeLeft < 0)
      {
        _timeLeft = 0;
      }
      float minutes = Mathf.FloorToInt(_timeLeft / 60);
      float seconds = Mathf.FloorToInt(_timeLeft % 180);
      timerText.text = ($"{seconds}/{time}");
    }
  }
}

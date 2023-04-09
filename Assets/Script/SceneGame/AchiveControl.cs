using TMPro;
using UnityEngine;

namespace Reducer
{
  public class AchiveControl : MonoBehaviour
  {
    private float time = 0;
    private int wantkill = 5;
    [SerializeField] private GameObject AchiveTime;
    [SerializeField] private GameObject AchiveKill;
    [SerializeField] private GameObject Timeimage;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject Killimage;
    [SerializeField] private TextMeshProUGUI Textkills;
    [SerializeField] private GameObject panelwin;
    private LevelsSettings levelsSettings;
    public Pause pause;
    private float timeLeft;
    private bool LevelComplete = false;
    private bool timerOn = false;
    private bool workkill = false;
    public int nowkill = 0;
    public bool achiveKills = true;
    public bool achiveTime = true;

    private void Awake()
    {
      levelsSettings = Resources.Load<LevelsSettings>($"Levels/{PlayerPrefs.GetString("CurrentLevel")}");
      if (levelsSettings.Time != 0)
      {
        time = levelsSettings.Time;
        timerOn = true;
        achiveTime = true;
      }
      else
      {
        timerOn = false;
        achiveTime = false;
        AchiveTime.SetActive(false);
      }
      if (levelsSettings.Kill != 0)
      {
        if (!timerOn)
        {
          AchiveKill.transform.GetComponent<RectTransform>().localPosition = AchiveTime.transform.GetComponent<RectTransform>().localPosition;
        }
        wantkill = levelsSettings.Kill;
        workkill = true;
        achiveKills = true;
      }
      else
      {
        workkill = false;
        achiveKills = false;
        AchiveKill.SetActive(false);
      }
    }
    private void Start()
    {
      timeLeft = 0f;
    }
    private void Update()
    {
      if (Time.timeScale == 1)
      {
        if (!LevelComplete)
        {
          if (timerOn! || workkill)
          {
            if (achiveTime && achiveKills)
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
            LevelComplete = true;
            SaveToPlayerPrefs.SaveLevel(); //LevelSave.instance.SaveInPlayerPrefs();
            panelwin.SetActive(true);
            print("пауза прошли уровень");
            pause.Enable(true);
          }
        }
      }
    }
    private void _Time() //включение/выключение запуска времени  
    {
      if (timerOn)
      {
        if (timeLeft < time)
        {
          timeLeft += Time.deltaTime;
          UpdateTimeText();
        }
        else
        {
          timeLeft = time;
          timerOn = false;
          print($"{time} +{Singleton<FromScript>.Instance.NameScript()}");
        }
      }
    }
    private void _Kill() //включение/выключение посчёта килов
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
    public void CountKills() //подсчёт килов
    {
      if (nowkill < wantkill)
      {
        nowkill++;
      }
    }
    private void Kill()//обновление счётчика килов
    {
      Textkills.text = ($"{nowkill}/{wantkill}");
    }
    private void UpdateTimeText()//обновление таймера
    {
      if (timeLeft < 0)
      {
        timeLeft = 0;
      }
      float minutes = Mathf.FloorToInt(timeLeft / 60);
      float seconds = Mathf.FloorToInt(timeLeft % 180);
      timerText.text = ($"{seconds}/{time}");
    }
  }
}

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
    public float _timeLeft = 0f;
    private bool _killtime = false;
    private bool _timerOn = false;
    private bool _killOn = false;
    public GameObject panelwin;
    public Pause pause;

    [SerializeField] public int wantkill = 5;
    public int nowkill = 0;
    public static bool achiveKills = true;
    public static bool achiveTime = true;
    private void Start()
    {
      _timeLeft = 0f;
      _killtime = true;
      instance = this;
      //Timeimage.transform.position = new Vector3(-5.7f, 12f, 9);
      // timerText.transform.position = new Vector3(-4.5f, 12.1f, 9);
      // Textkills.transform.position = new Vector3(-4.5f, 10f, 9);
      // Killimage.transform.position = new Vector3(-6f, 10f, 9);
      if (GameObject.Find("Achivekills") == false)
      {
        _killOn = false;
        achiveKills = false;
      }
      else
      {
        _killOn = true;
        achiveKills = true;
      }
      if (GameObject.Find("AchiveTime") == false)
      {
        _timerOn = false;
        achiveTime = false;
        //Textkills.transform.position = new Vector3(-4.5f, 12f, 9);
        //Killimage.transform.position = new Vector3(-6f, 12f, 9);
      }
      else
      {
        _timerOn = true;
        achiveTime = true;
      }

    }
    public void Awake()
    {
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
      if (_killOn)
      {
        Kill();
        if (nowkill == wantkill)
        {
          _killOn = false;
        }

      }
    }

    public void Update()
    {
      if (Time.timeScale == 1)
      {
        if (_killtime)
        {
          if (_timerOn! || _killOn)
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
            _killtime = false;
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
    public void Kill()
    {
      Textkills.text = ($"{nowkill}/{wantkill}");
    }
  }
}

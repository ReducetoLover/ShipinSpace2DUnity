using System.Collections;
using UnityEngine;


namespace Reducer
{
  public class RespawnBot : MonoBehaviour
  {
    private LevelsSettings levelsSettings;
    [SerializeField] private GameObject Upborder;
    [SerializeField] private GameObject bot;
    [SerializeField] private int Secondsmin;
    [SerializeField] private int Secondsmax;
    [SerializeField] public int minXP;
    [SerializeField] public int maxXP;
    [SerializeField] public float Minfirebot;
    [SerializeField] public float Maxfirebot;


    private void Start()
    {
      levelsSettings = Resources.Load<LevelsSettings>($"Levels/{PlayerPrefs.GetString("SceneName")}");
      Upborder = GameObject.FindGameObjectWithTag("ZoneUp");
      StartCoroutine(TimeBot());
    }
    IEnumerator TimeBot()
    {
      yield return new WaitForSeconds(Random.Range(levelsSettings.MinRespawnbot, levelsSettings.MaxRespawnbot));
      float xpositionrespawn = Random.Range(-5f, 5f);
      Destroy(Instantiate(bot, new Vector2(xpositionrespawn, Upborder.transform.position.y + 1f), Quaternion.identity), 15f);
      StartCoroutine(TimeBot());
    }
  }
}

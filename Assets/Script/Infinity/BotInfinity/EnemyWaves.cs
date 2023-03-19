using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
  public class EnemyWaves : MonoBehaviour
  {
    private LevelData level;
    private int indexWave;
    private int indexEnemy;
    [SerializeField] private GameObject Upborder;
    private List<GameObject> enemies = new List<GameObject>();
    private void Awake()
    {
      int index = new LevelNameData().GetLevelIndex();
      level = Resources.Load<LevelData>($"Levels/Infinity");
    }
    public void Generate()
    {
      foreach (var wave in level.Waves)
      {
        for (int i = 0; i < wave.CountinWave; i++)
        {
          float x = Random.Range(-5f, 5f);
          var enemy = Instantiate(wave.EnemyPrefab,new Vector2(x,Upborder.transform.position.y+1f),Quaternion.identity);
          enemy.SetActive(false);
          enemies.Add(enemy);
        }
      }
    }
    public void Activate()
    {
      StartCoroutine(EnemyActivate());
    }
    private IEnumerator EnemyActivate()
    {
       
     
      var count = level.Waves[indexWave].CountinWave;
      while (count > 0)
      {
        count--;
        enemies[indexEnemy].gameObject.SetActive(true);
        indexEnemy++;
        yield return new WaitForSeconds(Random.Range(1, 7- indexWave));
      }
      if(indexWave < level.Waves.Count - 1)
      {
        
        Invoke(nameof(Activate), level.Waves[indexWave].WaitAfterWave);
        indexWave++;
      }
    }   
  }
}

using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class Respawn3DEnemy : MonoBehaviour
  {
    private ThreeDSettings threeDSettings;
    [SerializeField] private GameObject Enemy;

    private void Start()
    {
      threeDSettings = Resources.Load<ThreeDSettings>($"Levels/3DLevel");
      StartCoroutine(EnemyRespawn());
    }
    IEnumerator EnemyRespawn()
    {
      yield return new WaitForSeconds(Random.Range(threeDSettings.MinRespawnbot, threeDSettings.MaxRespawnbot));
      float x = Mathf.Round(Random.Range(-2, 2));
      Destroy(Instantiate(Enemy.gameObject, new Vector3(x, 0, 30f), Quaternion.identity), 15f);
      StartCoroutine(EnemyRespawn());
    }
  }
}

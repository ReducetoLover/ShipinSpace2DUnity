using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class Respawn3DEnemy : MonoBehaviour
  {
    [SerializeField]private GameObject Enemy;
    void Start()
    {
      StartCoroutine(EnemyRespawn());
    }
    IEnumerator EnemyRespawn()
    {
      yield return new WaitForSeconds(Random.Range(1,4));
      float x = Mathf.Round(Random.Range(-1,2));
      Destroy(Instantiate(Enemy.gameObject, new Vector3(x,0f,30f),Quaternion.identity),15f);
      StartCoroutine(EnemyRespawn());
     // print($"{x}+бот,+{FromScript.instance.NameScript()}");
    }
  }
}

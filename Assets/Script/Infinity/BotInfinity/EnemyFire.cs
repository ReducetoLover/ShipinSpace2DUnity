using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reducer
{
    public class EnemyFire : MonoBehaviour
    {
    public AudioSource botFiresound;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform gun;
    void Start()
    {
      StartCoroutine(BotFire());
    }
    public void BotFireOn()
    {
      StartCoroutine(BotFire());
    }
    IEnumerator BotFire()
    {
      yield return new WaitForSeconds(Random.Range(1f, 3f));
      FireBullet();
      botFiresound.Play();
      StartCoroutine(BotFire());
    }
    public void FireBullet()
    {
      Instantiate(bullet, gun.position, gun.rotation);
    }
  }
}

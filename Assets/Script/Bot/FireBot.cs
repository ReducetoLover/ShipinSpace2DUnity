using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class FireBot : MonoBehaviour
  {
    public AudioSource botFiresound;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject bot;
    [SerializeField]
    private Transform gun;
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
      yield return new WaitForSeconds(Random.Range(Singleton<RespawnBot>.Instance.Minfirebot, Singleton<RespawnBot>.Instance.Maxfirebot));
      FireBullet();
      botFiresound.Play();
      StartCoroutine(BotFire());
    }
    public void FireBullet()
    {
      Instantiate(bullet.gameObject, gun.position, gun.rotation);
    }
  }
}

using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class FireBot3D : MonoBehaviour
  {
    private ThreeDSettings threeDSettings;
    [SerializeField] private AudioSource botFiresound;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bot;
    [SerializeField] private Transform gun;
    private void Start()
    {
      threeDSettings = Resources.Load<ThreeDSettings>($"Levels/3DLevel");
      StartCoroutine(BotFire());
      print(threeDSettings.MinFirebot);
    }
    public void BotFireOn()
    {
      StartCoroutine(BotFire());
    }
    IEnumerator BotFire()
    {
      yield return new WaitForSeconds(Random.Range(threeDSettings.MinFirebot, threeDSettings.MaxFirebot + 1));
      //yield return new WaitForSeconds(Random.Range(Singleton<RespawnBot>.Instance.Minfirebot, Singleton<RespawnBot>.Instance.Maxfirebot));
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
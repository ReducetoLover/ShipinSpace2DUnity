using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class FireBot : MonoBehaviour
  {
    public static FireBot instance;
    public AudioSource botFiresound;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject bot;
    [SerializeField]
    private Transform gun;

    // Start is called before the first frame update
    void Start()
    {
      instance = this;
      StartCoroutine(BotFire());
    }

    // Update is called once per frame
    public void BotFireOn()
    {
      StartCoroutine(BotFire());
    }
    IEnumerator BotFire()
    {
      yield return new WaitForSeconds(Random.Range(RespawnBot.instance.Minfirebot, RespawnBot.instance.Maxfirebot));
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

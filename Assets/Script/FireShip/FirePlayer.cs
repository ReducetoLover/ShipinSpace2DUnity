using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class FirePlayer : MonoBehaviour
  {
    public static FirePlayer instance;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject ship;
    [SerializeField]
    private Transform gun;
    public AudioSource Fire;
    

    private void Start()
    {
      instance = this;
    }
    public void Shot()
    {
      Instantiate(bullet.gameObject, gun.position, gun.rotation);
      StartCoroutine(FireBullet());
    }
    public void ShorAutomata()
    {
      Shot();
      Fire.Play();
      StartCoroutine(FireBullet());
      print("запуск");
    }
    public void StopCorutine()
    {
      StopAllCoroutines();
    }
    IEnumerator FireBullet()
    {
      print("корутина");
      yield return new WaitForSeconds(0.3f);
      Shot();
      Fire.Play();

    }

  }
}



using System.Collections;
using UnityEngine;

namespace Reducer
{
  public class FirePlayer : MonoBehaviour
  {
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject ship;
    [SerializeField]
    private Transform gun;
    public AudioSource Fire;
    public void Shot()
    {
      Fire.Play();
      Instantiate(bullet.gameObject, gun.position, gun.rotation);
    }
    public void ShotAutomata()
    {
      StartCoroutine(FireBullet());
    }
    public void StopCorutine()
    {
      StopAllCoroutines();
    }
    IEnumerator FireBullet()
    {
      yield return new WaitForSeconds(0.3f);
      Shot();
      StartCoroutine(FireBullet());
    }
  }
}



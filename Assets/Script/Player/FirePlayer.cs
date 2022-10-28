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
      Fire.Play();
      Instantiate(bullet.gameObject, gun.position, gun.rotation);
      
    }
    public void ShotAutomata()
    {
      StartCoroutine(FireBullet());
      print("������");
    }
    public void StopCorutine()
    {
      StopAllCoroutines();
    }
    IEnumerator FireBullet()
    {
      print("��������");
      yield return new WaitForSeconds(0.2f);
      Shot();
      StartCoroutine(FireBullet());

    }

  }
}



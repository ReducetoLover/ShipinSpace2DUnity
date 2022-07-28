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

    // Start is called before the first frame update
    void Start()
    {

      StartCoroutine(BotFire());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator BotFire()
    {
      yield return new WaitForSeconds(Random.Range(RespawnBot.instance.Minfirebot, RespawnBot.instance.Maxfirebot));
      Destroy(Instantiate(bullet.gameObject, gun.position, gun.rotation), 1.5f);
      botFiresound.Play();
      StartCoroutine(BotFire());

    }


  }
}

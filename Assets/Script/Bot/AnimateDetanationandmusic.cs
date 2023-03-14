using UnityEngine;

namespace Reducer
{
  public class AnimateDetanationandmusic : MonoBehaviour
  {
    public AudioSource hit;
    public AudioSource detonation;
    [SerializeField]
    private ParticleSystem vfx;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Hit()
    {
       hit.Play();
    }
    public void PlayAnimateDetonationBot(Vector3 a)
    {
      print($"взрыв+{Singleton<FromScript>.Instance.NameScript()}");
      vfx.transform.position = a;
      Instantiate(vfx);
      vfx.Play();
      detonation.Play();
    }
    // Update is called once per frame
    void Update()
    {

    }
  }
}

using UnityEngine;

namespace Reducer
{
  public class AnimateDetanationandmusic : MonoBehaviour
  {
    [SerializeField] private AudioSource hit;
    [SerializeField] private AudioSource detonation;
    [SerializeField] private ParticleSystem vfx;
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
  }
}

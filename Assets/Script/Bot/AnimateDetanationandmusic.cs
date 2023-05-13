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
    public void PlayAnimateDetonationBot(Vector3 placeafterdestroy)
    {
      print($"взрыв+{Singleton<FromScript>.Instance.NameScript()}");
      vfx.transform.position = placeafterdestroy;
      vfx.Simulate(0.0f, true, true);
      vfx.Play();
      detonation.Play();
    }
  }
}

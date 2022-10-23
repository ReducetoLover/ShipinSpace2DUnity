using UnityEngine;

namespace Reducer
{
  public class AnimateDetanationandmusic : MonoBehaviour
  {
    public AudioSource hit;
    public AudioSource detonation;
    public static AnimateDetanationandmusic instance;
    [SerializeField]
    private ParticleSystem vfx;
    // Start is called before the first frame update
    void Start()
    {
      instance = this;
    }
    public void play(Vector3 a)
    {
      print($"взрыв+{FromScript.instance.NameScript()}");
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

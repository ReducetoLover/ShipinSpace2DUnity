using UnityEngine;

namespace Reducer
{
  public class Particle : MonoBehaviour
  {
    [SerializeField]
    public ParticleSystem part;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void play()
    {
      part.Play();
    }
    public void stop()
    {
      part.Stop();
    }
    // Update is called once per frame
    void Update()
    {

    }
  }
}

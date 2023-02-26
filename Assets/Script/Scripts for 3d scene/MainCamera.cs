using System.Security.Principal;
using UnityEngine;

namespace Reducer
{
  public class MainCamera : MonoBehaviour
  {
    public GameObject player;
    public GameObject camera;
    private Vector3 offset;

    void Start()
    {
     
    }

    private void Update()
    {
      transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
  }
}

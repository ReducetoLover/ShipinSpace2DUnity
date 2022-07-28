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

    private void Start()
    {

    }
    public void Shot()
    {
      Destroy(Instantiate(bullet.gameObject, gun.position, gun.rotation), 1.5f);
    }

  }
}



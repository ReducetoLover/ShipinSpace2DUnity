using UnityEngine;

namespace Reducer
{
  public class Test3dRay : MonoBehaviour
  {
    private bool workRay = true;
    [SerializeField] private Transform border;
    RaycastHit hit;
    private bool Onwork;
    public void CreateRay3D()
    {
      int bitmask = ~((1 << 7) | (1 << 6));
      Ray ray = new Ray(transform.position, transform.forward);
      float distation = Vector3.Distance(transform.position, border.position);
      Debug.DrawRay(transform.position, transform.forward * distation, Color.red);
      Onwork = Physics.Raycast(ray, out hit, distation, bitmask);
      if (Physics.Raycast(ray, out hit, distation, bitmask))
      {
        CheckCollider3D(ref workRay);
      }

    }
    private void FixedUpdate()
    {
      CreateRay3D();

    }
    public void CheckCollider3D(ref bool workRay)
    {
      if (hit.collider.CompareTag("bot") & workRay == true)
      {
        Singleton<FirePlayer>.Instance.ShotAutomata();
        workRay = false;
      }
      else if (!hit.collider.CompareTag("bot") & workRay == false)
      {
        Singleton<FirePlayer>.Instance.StopAllCoroutines();
        workRay = true;
      }
    }
  }
}

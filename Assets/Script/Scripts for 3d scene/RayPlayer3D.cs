using GooglePlayGames.BasicApi;
using UnityEngine;

namespace Reducer
{
  public class RayPlayer3D : MonoBehaviour
  {
    [SerializeField] private Transform player;
    [SerializeField] private Transform border;
    [SerializeField] private RaycastHit2D hit;
    private bool workRay = false;
    private void FixedUpdate()
    {
      CreateRay();
      CheckCollider(ref workRay);
    }
    private void CreateRay()
    {
      int bitmask = ~((1 << 7) | (1 << 6));
      float distation = 20f;
      hit = Physics2D.Raycast(player.position, player.TransformDirection(Vector3.forward), distation, bitmask);
      Debug.DrawRay(player.position, player.TransformDirection(Vector3.forward) * distation, Color.green);
      print(hit.collider.name);
    }

    public void CheckCollider(ref bool workRay)
    {
      if (hit.collider.CompareTag("bot") && workRay == true)
      {
        Singleton<FirePlayer>.Instance.ShotAutomata();
        workRay = false;
      }
      else if (!hit.collider.CompareTag("bot") && workRay == false)
      {
        print("стопколлайдер");
        Singleton<FirePlayer>.Instance.StopAllCoroutines();
        workRay = true;
      }
    }
  }
}

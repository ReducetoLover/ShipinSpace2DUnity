using UnityEngine;

namespace Reducer
{
  public class RayPlayer : MonoBehaviour
  {
    [SerializeField] private Transform player;
    [SerializeField] private Transform border;
    [SerializeField] private RaycastHit2D hit;
    private bool workRay = false;
    private void FixedUpdate()
    {
      int bitmask = ~((1 << 7) | (1 << 6));
      float distation = Vector2.Distance(player.position, border.position);
      Debug.DrawRay(player.position, player.TransformDirection(Vector2.down) * distation, Color.green);
      hit = Physics2D.Raycast(player.position, player.TransformDirection(Vector2.down), distation, bitmask);
      //print(hit.collider.name);
      if (hit.collider.CompareTag("bot") && workRay == true)
      {
        FirePlayer.instance.ShotAutomata();
        workRay = false;
      }
      else if (!hit.collider.CompareTag("bot") && workRay == false)
      {
        print("стопколлайдер");
        FirePlayer.instance.StopAllCoroutines();
        workRay = true;
      }
    }

  }
}


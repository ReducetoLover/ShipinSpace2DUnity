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
      CreateRay();
      CheckCollider(ref workRay);
    }
    private void CreateRay()
    {
      int bitmask = ~((1 << 7) | (1 << 6));
      float distation = Vector2.Distance(player.position, border.position);
      hit = Physics2D.Raycast(player.position, player.TransformDirection(Vector2.down), distation, bitmask);
      Debug.DrawRay(player.position, player.TransformDirection(Vector2.down) * distation, Color.green);
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
        print("�������������");
        Singleton<FirePlayer>.Instance.StopAllCoroutines();
        workRay = true;
      }
    }
  }
}


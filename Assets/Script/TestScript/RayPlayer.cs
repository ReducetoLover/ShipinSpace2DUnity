using System;
using UnityEngine;

namespace Reducer
{
  public class RayPlayer : MonoBehaviour
  {
    [SerializeField] private RaycastHit2D hitray;
    [SerializeField] private Transform player;
    [SerializeField] private Transform border;
    public bool test = true;

    void Start()
    {

    }

    private void Update()
    {
      float distation = Vector2.Distance(player.transform.position, border.transform.position);
      Debug.DrawRay(player.position, player.TransformDirection(Vector2.down) * distation, Color.green);
      Vector2 b = player.transform.TransformDirection(Vector2.down) * distation;
      //print(Convert.ToInt32(b.y));
      RaycastHit2D hit = Physics2D.Raycast(player.position, player.TransformDirection(Vector2.down), Convert.ToInt32(b.y));

      if (hit.collider.name == "bot(Clone)" && test == true)
      {
        FirePlayer.instance.ShotAutomata();
        test = false;
      }
      else if (hit.collider.name != "bot(Clone)" && test == false)
      {
        FirePlayer.instance.StopAllCoroutines();
        test = true;
      }
    }
  }
}


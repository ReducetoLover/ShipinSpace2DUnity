using Packages.Rider.Editor.UnitTesting;
using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Reducer
{
  public class RayPlayer : MonoBehaviour
  {
    [SerializeField] private RaycastHit2D hitray;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject border;
    public bool test = true;

    void Start()
    {

    }

    private void Update()
    {
      float distation = Vector2.Distance(player.transform.position, border.transform.position);
      Debug.DrawRay(player.transform.position, player.transform.TransformDirection(Vector2.down)*distation, Color.green);
      Vector2 b = player.transform.TransformDirection(Vector2.down) * distation;
      print(Convert.ToInt32(b.y));
      RaycastHit2D hit = Physics2D.Raycast(player.transform.position, player.transform.TransformDirection(Vector2.down), Convert.ToInt32(b.y));
      if (hit.collider != null)
      {
        if (hit.collider.name == "bot(Clone)" && test == true)
        {
          print(test);
          FirePlayer.instance.ShorAutomata();
          test = false;
        }
      }
      if (hit.collider == null)
      {
        FirePlayer.instance.StopCorutine();
        test = true;
      }
    }
  }
}

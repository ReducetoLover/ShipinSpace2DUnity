using System;
using UnityEngine;
using UnityEngine.EventSystems;

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
      int bitmask =  ~((1<<7));//���� ���������
      float distation = Vector2.Distance(player.position, border.position);
      Debug.DrawRay(player.position, player.TransformDirection(Vector2.down) * distation, Color.green);
      RaycastHit2D hit = Physics2D.Raycast(player.position, player.TransformDirection(Vector2.down), distation, bitmask);
      //print(hit.collider.name);
      if (hit.collider.tag == "bot" && test == true)
      {
        FirePlayer.instance.ShotAutomata();
        test = false;
      }
      else if (hit.collider.tag != "bot" && test == false)
      {
        print("�������������");
        FirePlayer.instance.StopAllCoroutines();
        test = true;
      }
    }
    public float Bot()
    {

      return 4f;
    }
  }
}


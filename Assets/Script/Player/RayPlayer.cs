using UnityEngine;

namespace Reducer
{
    public class RayPlayer : MonoBehaviour
    {
        [SerializeField] private RaycastHit2D hitray;
        [SerializeField] private Transform player;
        [SerializeField] private Transform border;
        [SerializeField] private RaycastHit2D hit;
        public bool test = false;

        void Start()
        {

        }

        private void Update()
        {
            int bitmask = ~((1 << 7) | (1 << 6));
            float distation = Vector2.Distance(player.position, border.position);
            Debug.DrawRay(player.position, player.TransformDirection(Vector2.down) * distation, Color.green);
            hit = Physics2D.Raycast(player.position, player.TransformDirection(Vector2.down), distation, bitmask);
            //print(hit.collider.name);
            if (hit.collider.CompareTag("bot") && test == true)
            {
                FirePlayer.instance.ShotAutomata();
                test = false;
            }
            else if (!hit.collider.CompareTag("bot") && test == false)
            {
                print("стопколлайдер");
                FirePlayer.instance.StopAllCoroutines();
                test = true;
            }
        }

    }
}


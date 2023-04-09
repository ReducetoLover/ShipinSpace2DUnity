using UnityEngine;

namespace Reducer
{
  public class BackGround : MonoBehaviour
  {
    [SerializeField] private GameObject[] sprite;
    [SerializeField] private float speed = 2.5f;
    private LevelsSettings testlevel;
    private float positionMinY;
    private Vector2 restartPosition;
    private void Start()
    {
      testlevel = Resources.Load<LevelsSettings>($"Levels/{PlayerPrefs.GetString("CurrentLevel")}");
      sprite = GameObject.FindGameObjectsWithTag("Sky");
      for (int i = 0; i < sprite.Length; i++)
      {
        sprite[i].GetComponent<SpriteRenderer>().color = testlevel.colorSky;
        //_sprite[i].transform.position = new Vector3(0, -25.6f + i * 12.8f, 0);
      }
      restartPosition = transform.position;
      positionMinY = sprite[0].GetComponent<SpriteRenderer>().size.y - restartPosition.y;// две высоты спрайта - начальная позиция по Y
    }
    private void Update()
    {
      transform.Translate(Vector3.down * speed * Time.deltaTime);
      if (transform.position.y <= -positionMinY)
      {
        transform.position = restartPosition;
      }
    }
  }
}

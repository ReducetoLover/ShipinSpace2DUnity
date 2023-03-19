using UnityEngine;
using UnityEngine.Events;

namespace Reducer
{
  public class ScoreCollected : MonoBehaviour
  {
    [SerializeField] private UnityEvent<int> ScoreChanged;
    private int scoreCollected;
    private void OnDisable()
    {
      ObjectScore.OnChanged -= ObjectScoreOnChanged;
    }
    private void OnEnable()
    {
      ObjectScore.OnChanged += ObjectScoreOnChanged;
    }
    private void ObjectScoreOnChanged(int value)
    {
      Debug.Log(scoreCollected+ "— ŒÀ‹ Œ Œ◊ Œ¬");
      scoreCollected += value; 
      ScoreChanged.Invoke(scoreCollected);
    }
    private void Awake()
    {
      ScoreChanged.Invoke(scoreCollected);
    }
  }
}

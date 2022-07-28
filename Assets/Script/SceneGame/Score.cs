using System.Collections;
using TMPro;
using UnityEngine;

namespace Reducer
{
  public class Score : MonoBehaviour
  {
    [SerializeField]
    public static int money;
    public int total_money;
    public TextMeshProUGUI moneyText;
    // Start is called before the first frame update
    void Start()
    {
      money = PlayerPrefs.GetInt("money");
      total_money = PlayerPrefs.GetInt("total_money");
      bool isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
      if (isFirst == false)
      {
        StartCoroutine(IdleFarm());
      }
    }

    // Update is called once per frame
    void Update()
    {
      moneyText.text = money.ToString();
    }
    IEnumerator IdleFarm()
    {
      yield return new WaitForSeconds(1);
      money++;
      Debug.Log(money);
      PlayerPrefs.SetInt("money", money);
      StartCoroutine(IdleFarm());
    }
  }
}

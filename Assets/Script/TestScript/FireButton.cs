using UnityEngine;
using UnityEngine.UI;

namespace Reducer
{
    public class FireButton : MonoBehaviour
    {

         public static FireButton instance;
        public GameObject Fire;
        public GameObject Player;
        //public Toggle tog1;
        //public Toggle tog2;

        // Start is called before the first frame update
        private void Awake()
        {
            instance = this;
      //
      //
         
     
        }
        void Start()
        {

     // TestToggle.instance.Choice = PlayerPrefs.GetString("ChoiceControl");
      if (TestToggle.instance.Choice == "button")
      {
        //tog1.isOn = false;
        //tog1.isOn = true;
        print("Зашёл на 1");
        Player = GameObject.Find("Player");
        Fire = GameObject.Find("Fire");
        Player.GetComponent<RayPlayer>().enabled = false;
        // Fire.SetActive(true);
        Fire.GetComponent<Image>().enabled = true;
        print(19);

      }
      else
      {
        //tog1.isOn = true;
        //tog2.isOn = false;
        print("Зашёл на 0");
        Player = GameObject.Find("Player");
        Fire = GameObject.Find("Fire");
        Player.GetComponent<RayPlayer>().enabled = true;
        //Fire.SetActive(false);
        Fire.GetComponent<Image>().enabled = false;
      }
    }
        //public void PutButton()
        //{
        //  tog2.isOn = false;
        //  Choice = 0;
        //  print($"{Choice}+{FromScript.instance.NameScript()} 567");
        //  PlayerPrefs.SetInt("Choice", Choice);
        //  PlayerPrefs.Save();
        //}
        //public void PutAutomatic()
        //{
        //  tog1.isOn = false;
        //  Choice = 1;
        //  print($"{Choice}+{FromScript.instance.NameScript()}");
        //  PlayerPrefs.SetInt("Choice", Choice);
        //  PlayerPrefs.Save();
        //}
    }
}


using UnityEngine;

namespace Reducer
{
    public class TestToggle : MonoBehaviour
    {
        public string Choice;
        public static TestToggle instance;

        void Start()
        {
            instance = this;
            Choice = PlayerPrefs.GetString("ChoiceControl");
            print($"{Choice}+{FromScript.instance.NameScript()} При старте");
    }
        void Update()
        {

        }
        public void Put()
        {
            if (Choice == "automate")
                Choice = "button";
            else
                Choice = "automate";
            print($"{Choice}+{FromScript.instance.NameScript()} При нажатии");
            PlayerPrefs.SetString("ChoiceControl", Choice);
            PlayerPrefs.Save();
        }
    }
}

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Reducer
{
  public class Sound : MonoBehaviour
  {
    [SerializeField] private GameObject MusicObj;
    [SerializeField] private AudioMixerGroup mixer;
    private int Music;
    private void Start()
    {
      Music = PlayerPrefs.GetInt("SaveMusic");
      if (Music == 0)
      {
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1f);
        mixer.audioMixer.SetFloat("MusicVolume", 0);
      }
      else if (Music == 1)
      {
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 0.5f);
        mixer.audioMixer.SetFloat("MusicVolume", -80);
      }
    }
    public void PlayMusic()
    {
      if (Music == 1)
      {
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1f);
        mixer.audioMixer.SetFloat("MusicVolume", 0);
        Music = 0;
      }
      else if (Music == 0)
      {
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 0.5f);
        mixer.audioMixer.SetFloat("MusicVolume", -80);
        Music = 1;
      }
      PlayerPrefs.SetInt("SaveMusic", Music);
      PlayerPrefs.Save();
    }
  }
}

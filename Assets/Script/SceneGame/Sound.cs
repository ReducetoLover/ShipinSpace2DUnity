using UnityEngine;
using UnityEngine.Audio;
using System;
using Unity;
using UnityEngine.UI;

namespace Reducer
{
  public class Sound : MonoBehaviour
  {
    public GameObject MusicObj;
    public AudioMixerGroup mixer;
    private int Music;
    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
      Music = PlayerPrefs.GetInt("SaveMusic");
      print(Music);
      if (Music == 0)
      {
        print("работает");
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1f);
        mixer.audioMixer.SetFloat("MusicVolume", 0);
      }
      else if (Music == 1)
      {
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 0.5f);
        mixer.audioMixer.SetFloat("MusicVolume", -80);
      }
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void PlayMusic()
    {
      if (Music == 1)
      {
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 1f);
        mixer.audioMixer.SetFloat("MusicVolume", 0);
        Music = 0;
      }
      else if (Music==0)
      {
        MusicObj.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 255 / 255.0f, 0.5f);
        mixer.audioMixer.SetFloat("MusicVolume", -80);
        Music = 1;
      }
      PlayerPrefs.SetInt("SaveMusic", Music);
      PlayerPrefs.Save();
      print("Music");
      print(Music);
    }
  }
}

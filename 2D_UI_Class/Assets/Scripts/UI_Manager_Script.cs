using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager_Script : MonoBehaviour
{
    private bool InitSetting;

    // Start is called before the first frame update
   private void Start()
    {
        InitSetting = false;
    }

    // Update is called once per frame
   private void Update()
    {
        
    }

   public void MyLogInButton_in_UIManager()
    {
        Debug.Log("button 2 click");
    }

    public void SettingButton_UIManager(GameObject Setting)
    {
        if (!InitSetting)
        {
            Setting.SetActive(true);
            InitSetting = true;
        }
    }

    public void ExitButton(GameObject Setting)
    {
        Setting.SetActive(false);
        InitSetting = false;
    }

    public void SoundMute(AudioSource audio)
    {
        audio.mute = true;
    }
    public void SoundOn(AudioSource audio)
    {
        audio.mute = false;
    }
}

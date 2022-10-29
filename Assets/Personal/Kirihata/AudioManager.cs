using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer Mixer;

    [SerializeField] Slider BGMSlider;
    [SerializeField] Text BGMValueText;
    [SerializeField] Slider SESlider;
    [SerializeField] Text SEValueText;

    float tmp;

    public void SetBGM()
    {
        BGMValueText.text = BGMSlider.value.ToString("F1");
        SetVolume(BGMSlider.value, "BGMVolume");
    }

    public void SetSE()
    {
        SEValueText.text = SESlider.value.ToString("F1");
        SetVolume(SESlider.value,"SEVolume");
    }

    void SetVolume(float value,string target) 
    {
        tmp = value / 3;
        tmp = Mathf.Clamp(Mathf.Log10(tmp) * 20f, -80f, 0f);
        Mixer.SetFloat(target, tmp);
    }
}

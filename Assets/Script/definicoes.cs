using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class definicoes : MonoBehaviour
{

    public AudioMixer audioMixer;
    public Dropdown resolucaoDrop;
    Resolution[] resolutions;


    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        resolucaoDrop.ClearOptions();
        List<string> options = new List<string>();
        int currentResolitionIndex = 0;
        for (int i=0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " X " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width 
                && resolutions[i].height==Screen.currentResolution.height)
            {
                currentResolitionIndex = i;
            }
        }
        resolucaoDrop.AddOptions(options);
        resolucaoDrop.value = currentResolitionIndex;
        resolucaoDrop.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume",volume);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

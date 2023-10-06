using UnityEngine;
using UnityEngine.UI;

public class VolumeUpAndDown : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject Volume;
    [SerializeField] GameObject Player; 

    public void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = slider.value;
        Save();
    }

    public void Load()
    {
        slider.value = PlayerPrefs.GetFloat("musicVolume", slider.value);
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", slider.value);
    }

    public void Sound()
    {
        Volume.SetActive(true);
        Player.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Playable()
    {
        Volume.SetActive(false);
        Time.timeScale = 1;
        Player.SetActive(true);
    }
}

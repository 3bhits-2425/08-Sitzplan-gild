using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Audiomenu : MonoBehaviour
{
    [SerializeField] private AudioSource myaudioSource;
    private TMP_Text buttontxt;
    private GameObject button;
    private void Awake()
    {
        button = GameObject.Find("PlayPauseButton");
        buttontxt = button.GetComponentInChildren<TMP_Text>();
        myaudioSource = GetComponent<AudioSource>();
    }
    public void PlayAudio()
    {
        myaudioSource.Play();
    }

    public void PauseAudio()
    {
        myaudioSource.Pause();
    }

    public void StopAudio()
    {
        myaudioSource.Stop();
    }
    public void PlayPauseAudio()
    {
        if (myaudioSource.isPlaying)
        {
            buttontxt.text = "Play";
            myaudioSource.Pause();
        }
        else
        {
            buttontxt.text = "Pause";
            myaudioSource.Play();
        }
    }
}



using UnityEngine.Audio;
using UnityEngine;

//Klasse sound muss Serialisierbar sien
[System.Serializable]
public class Sound
{

    //Instanzvariablen fuer eine Audio-Datei
    //Name der Audio´-Datei

    public string name;
    
    //Der Audio-Clip
    public AudioClip clip;

    //die Lautstearke
    [Range(0f,1f)] //Bereich gültiger Zahlenwerte
    public float volume;

    //der Pitch
    [Range(0.1f,3f)] //Bereich gültiger Zahlenwerte
    public float pitch;

    public AudioSource audioSource;

 
}

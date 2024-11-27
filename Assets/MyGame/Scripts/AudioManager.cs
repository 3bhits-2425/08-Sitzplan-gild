using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Instanzvariablen 
    [SerializeField]

    private Sound[] sounds;

    // speichern einer Referenz zum Singleton
    private AudioManager singleton;

    // stelle sicher, dass nur ein Element vom Typ AudioManager 
    // erzeugt werden kann

    void Awake()
    {
        if (singleton == null)
        {
            // noch kein AudioManager vorhanden
            // -> erzeuge einen
            singleton = this;
            //speicher die aktuelle Inzanz im Singleton
        }
        else
        {
            // es existiert bereits ein AudioManager
            // -> erzeuge keinen neuen
            // -> zerstoere aktuelles Objekt
            Destroy(gameObject);
            return;
        }

        // Singleton soll nicht zerstoert werden
        DontDestroyOnLoad(gameObject);

        foreach (Sound oneSound in sounds)
        {
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();
            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume = oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;


            /*
             * for (int i = 0; i < sounds.Length; i++){
             * Sound s = sounds[i];
             *......
             *identisch wie in forech
            */
        }

    }

    // Spielt soud ab   
    public void Play(string soundName)
    {
        FindSound(soundName).audioSource.Play();

    }

    public void Pause(string soundName)
    {
        FindSound(soundName).audioSource.Pause();
        /*
             * Sound my Sound = FindSound("09-mySound-fgrasboeck");
             *puasiere Sound
             *mySound.audioSource.Pause();
             */
    }
    private Sound FindSound(string soundName)
    {
        foreach (Sound oneSound in sounds)
        {
            if (oneSound.name == soundName)
            {
                return oneSound;
            }
        }
        return null;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
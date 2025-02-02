using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Music")]
    public AudioClip backgroundMusic;
    public float musicVolume = 0.3f;
    
    [Header("Sound Effects")]
    public AudioClip jumpSound;
    public AudioClip perfectSound;
    public AudioClip gameOverSound;
    public float effectsVolume = 0.5f;

    private AudioSource musicSource;
    private AudioSource effectsSource;

    void Start()
    {
        // Crée deux AudioSource : un pour la musique, un pour les effets
        musicSource = gameObject.AddComponent<AudioSource>();
        effectsSource = gameObject.AddComponent<AudioSource>();

        // Configure la source de musique
        musicSource.clip = backgroundMusic;
        musicSource.volume = musicVolume;
        musicSource.loop = true;
        musicSource.Play();

        // Configure la source d'effets
        effectsSource.volume = effectsVolume;
    }

    public void PlayJumpSound()
    {
        effectsSource.PlayOneShot(jumpSound);
    }

    public void PlayPerfectSound()
    {
        effectsSource.PlayOneShot(perfectSound);
    }

    public void PlayGameOverSound()
    {
        effectsSource.PlayOneShot(gameOverSound);
    }

    public void StopMusic()
    {
        if (musicSource != null)
        {
            musicSource.Stop();
        }
    }
} 
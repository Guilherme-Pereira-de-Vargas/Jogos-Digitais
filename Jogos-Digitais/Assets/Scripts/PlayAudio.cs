using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private AudioSource audioSource;
    public AudioClip audioCoins;
    public AudioClip audioJump;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySFX(AudioClip sfx) 
    {
        audioSource.PlayOneShot(sfx);
    }
}

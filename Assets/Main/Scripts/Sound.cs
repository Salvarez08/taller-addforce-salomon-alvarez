using UnityEngine;

public class Sound: MonoBehaviour
{
    
    public AudioClip collisionSoundClip;
    private AudioSource audioSource;

    void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collisionSoundClip != null && audioSource != null)
        {
           
            audioSource.PlayOneShot(collisionSoundClip);

           
        }
    }
}


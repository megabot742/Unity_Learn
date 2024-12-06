using UnityEngine;

public class SoundBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] AudioClip bounceSound;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            audioSource.PlayOneShot(bounceSound);
        }
    }
}

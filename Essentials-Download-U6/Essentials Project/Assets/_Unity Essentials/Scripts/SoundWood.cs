using Unity.VisualScripting;
using UnityEngine;

public class SoundWood : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] AudioClip audioClip;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}

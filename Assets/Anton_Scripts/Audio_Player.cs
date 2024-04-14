using UnityEngine;
using UnityEngine.UI;

public class Audio_Player : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public Toggle loopToggle;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlayRandomSound()
    {
        Debug.Log("Playing a sound");
        if (audioClips.Length == 0)
        {
            Debug.LogWarning("No audio clips assigned.");
            return;
        }

        AudioClip clipToPlay = audioClips[Random.Range(0, audioClips.Length)];
        bool loop = (loopToggle != null && loopToggle.isOn);

        audioSource.clip = clipToPlay;
        audioSource.loop = loop;

        audioSource.Play();
    }
}

using System.Threading;
using UnityEngine;

public class MusicTriggers : MonoBehaviour
{
    public AudioSource audioSource;

    public GameObject PlayTrigger;
    public GameObject PauseTrigger;

    public Material ActiveTrigger;
    public Material InactiveTrigger;

    private bool IsPaused = true;
    private bool IsPlaying = false;
    private float Duration = 0f;

    private void Update()
    {
        if(IsPlaying)
        {
            Duration += Time.deltaTime;

            if (Duration >= audioSource.clip.length)
            {
                PauseTrigger.GetComponent<Renderer>().material = ActiveTrigger;
                PlayTrigger.GetComponent<Renderer>().material = InactiveTrigger;
                Duration = 0f;
                audioSource.Stop();
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayTrigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            PauseTrigger.GetComponent<Renderer>().material = InactiveTrigger;
            IsPaused = false;
            IsPlaying = true;

            if (IsPaused)
            {
                audioSource.UnPause();
            }
            else
            {
                audioSource.Play();
            }
        }

        if(other.gameObject.CompareTag("PauseTrigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            PlayTrigger.GetComponent<Renderer>().material = InactiveTrigger;

            audioSource.Pause();
            IsPaused = true;
            IsPlaying = false;
        }
    }
}

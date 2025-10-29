using UnityEngine;

public class MusicTriggers : MonoBehaviour
{
    public AudioSource audioSource;

    public GameObject PlayTrigger;
    public GameObject PauseTrigger;

    public Material ActiveTrigger;
    public Material InactiveTrigger;

    private bool IsPaused = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayTrigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            PauseTrigger.GetComponent<Renderer>().material = InactiveTrigger;
            IsPaused = false;

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
        }
    }
}

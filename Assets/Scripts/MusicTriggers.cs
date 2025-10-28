using UnityEngine;

public class MusicTriggers : MonoBehaviour
{
    public AudioSource audioSource;

    public GameObject PlayTrigger;
    public GameObject PauseTrigger;

    public Material ActiveTrigger;
    public Material InactiveTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayTrigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            PauseTrigger.GetComponent<Renderer>().material = InactiveTrigger;

            if(1 == 1 /* audio source is paused */)
            {

            }
            //Debug.Log("Play Trigger");
        }

        if(other.gameObject.CompareTag("PauseTrigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            PlayTrigger.GetComponent<Renderer>().material = InactiveTrigger;

            audioSource.Pause();
            //Debug.Log("Pause Trigger");
        }
    }
}

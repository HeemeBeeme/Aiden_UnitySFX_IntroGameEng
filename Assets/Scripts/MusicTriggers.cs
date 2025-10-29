using System.Threading;
using UnityEngine;

public class MusicTriggers : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject PauseTrigger;

    public Material ActiveTrigger;
    public Material InactiveTrigger;

    private bool IsPaused = false;

    private void OnTriggerEnter(Collider other)
    {
        if(IsPaused)
        {
            //unpause
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            IsPaused = false;
            audioSource.Play();
        }
        else
        {
            other.gameObject.GetComponent<Renderer>().material = InactiveTrigger;
            audioSource.Pause();
            IsPaused = true;
        }
        

        
    }
}

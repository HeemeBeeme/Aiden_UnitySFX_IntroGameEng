using UnityEngine;

public class MusicTriggers : MonoBehaviour
{
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
            //Debug.Log("Play Trigger");
        }

        if(other.gameObject.CompareTag("PauseTrigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            PlayTrigger.GetComponent<Renderer>().material = InactiveTrigger;
            //Debug.Log("Pause Trigger");
        }
    }
}

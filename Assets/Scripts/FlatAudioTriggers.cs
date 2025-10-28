using UnityEngine;

public class FlatAudioTriggers : MonoBehaviour
{
    public GameObject Clip1Trigger;
    public GameObject Clip2Trigger;

    public Material ActiveTrigger;
    public Material InactiveTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Clip1Trigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            //Debug.Log("Clip 1 Trigger");
        }

        if (other.gameObject.CompareTag("Clip2Trigger"))
        {
            other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;
            //Debug.Log("Clip 2 Trigger");
        }
    }
}

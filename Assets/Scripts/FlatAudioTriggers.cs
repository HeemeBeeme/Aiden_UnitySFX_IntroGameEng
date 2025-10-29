using UnityEngine;

public class FlatAudioTriggers : MonoBehaviour
{
    public AudioSource Clip1Source;
    public AudioSource Clip2Source;

    public GameObject Clip1Trigger;
    public GameObject Clip2Trigger;

    public Material ActiveTrigger;
    public Material InactiveTrigger;

    private float Duration = 0f;
    private float Duration2 = 0f;
    private bool Clip1Wait = true;
    private bool Clip2Wait = true;

    private void Update()
    {
        if(Clip1Wait == false)
        {
            Duration += Time.deltaTime;

            if(Duration >= Clip1Source.clip.length)
            {
                Clip1Wait = true;
                Duration = 0f;
                Clip1Trigger.GetComponent<Renderer>().material = InactiveTrigger;
            }
        }

        if (Clip2Wait == false)
        {
            Duration2 += Time.deltaTime;

            if (Duration2 >= Clip2Source.clip.length)
            {
                Clip2Wait = true;
                Duration2 = 0f;
                Clip2Trigger.GetComponent<Renderer>().material = InactiveTrigger;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Clip1Trigger"))
        {
            if(Clip1Wait)
            {
                other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;

                Clip1Source.Play();

                if (Duration == 0f)
                {
                    Clip1Wait = false;
                }
            }
            
        }

        if (other.gameObject.CompareTag("Clip2Trigger"))
        {
            if (Clip2Wait)
            {
                other.gameObject.GetComponent<Renderer>().material = ActiveTrigger;

                Clip2Source.Play();

                if (Duration2 == 0f)
                {
                    Clip2Wait = false;
                }
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class BeamAccumurater2 : MonoBehaviour
{
    [SerializeField] private ParticleSystem beamParticle;
    [SerializeField] private AudioSource audio;



    //ƒr[ƒ€‚ğ•ú‚Â‰‰o‚ğÄ¶
    private void shot()
    {
        audio.PlayOneShot(audio.clip);

        beamParticle.Play();
    }

    public void OnParticle()
    {
        shot();
    }
}
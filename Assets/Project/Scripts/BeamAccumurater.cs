using UnityEngine;
using System.Collections;

public class BeamAccumurater : MonoBehaviour
{
    [SerializeField] ParticleSystem beamParticle;



    //魔法を貯めるパーティクルを再生
    private void shot()
    {
        beamParticle.Play();

    }

    public void OnParticle()
    {
        shot();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Controller : MonoBehaviour
{
    [SerializeField] private BeamShooter beamShooter;
    [SerializeField] private BeamAccumurater beamAccumurater;
    [SerializeField] private BeamAccumurater2 beamAccumurater2;



    // パーティクルを再生
    private IEnumerator StartParticle()
    {
        yield return new WaitForSeconds(2.0f);
        beamShooter.OnParticle();
        beamAccumurater.OnParticle();
        beamAccumurater2.OnParticle();
    }
}

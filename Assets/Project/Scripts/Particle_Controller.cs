using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Controller : MonoBehaviour
{
    [SerializeField] private BeamShooter beamShooter;
    [SerializeField] private BeamAccumurater beamAccumurater;
    [SerializeField] private BeamAccumurater2 beamAccumurater2;



    // �p�[�e�B�N�����Đ�
    private IEnumerator StartParticle()
    {
        yield return new WaitForSeconds(2.0f);
        beamAccumurater2.OnParticle();
        yield return new WaitForSeconds(1.8f);
        beamAccumurater.OnParticle();
        beamShooter.OnParticle();
    }
}

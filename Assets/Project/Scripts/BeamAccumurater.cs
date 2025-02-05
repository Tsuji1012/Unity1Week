using UnityEngine;
using System.Collections;

public class BeamAccumurater : MonoBehaviour
{
    [SerializeField] ParticleSystem beamParticle;



    //���@�𒙂߂�p�[�e�B�N�����Đ�
    private void shot()
    {
        beamParticle.Play();

    }

    public void OnParticle()
    {
        shot();
    }
}
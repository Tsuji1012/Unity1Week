using UnityEngine;
using System.Collections;

public class BeamAccumurater : MonoBehaviour
{
    [SerializeField] private Starter starter;

    float timer = 0.0f;
    float effectDisplayTime = 3.2f;
    ParticleSystem beamParticle;
    private bool swi = false;



    // Use this for initialization
    void Awake()
    {
        beamParticle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //�o�ߎ���
        timer += Time.deltaTime;

        //����̏����Ŗ��@�𒙂߂�p�[�e�B�N�����Đ�
        if (starter.startSwi == true)
        {
            if (swi == true)
            {
                swi = false;

                StartCoroutine(shot());
            }
            if (timer >= effectDisplayTime)
            {
                disableEffect();
            }
        }
    }

    //���@�𒙂߂�p�[�e�B�N�����Đ�
    private IEnumerator shot()
    {
        timer = 0f;
        beamParticle.Stop();

        yield return new WaitForSeconds(1.8f);
        beamParticle.Play();

    }

    //�p�[�e�B�N��������
    private void disableEffect()
    {
        beamParticle.Stop();
    }


    public void OnParticle()
    {
        swi = true;
    }
}
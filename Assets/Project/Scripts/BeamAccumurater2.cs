using UnityEngine;
using System.Collections;

public class BeamAccumurater2 : MonoBehaviour
{
    [SerializeField] private Starter starter;
    private new AudioSource audio;
    [SerializeField] private AudioClip accumurateSound;

    private float timer = 0.0f;
    private float effectDisplayTime = 2.2f;
    private ParticleSystem beamParticle;
    private bool swi = false;



    // Use this for initialization
    void Awake()
    {
        beamParticle = GetComponent<ParticleSystem>();

        audio = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //�o�ߎ���
        timer += Time.deltaTime;

        //����̏����Ńr�[��������o���Đ�
        if (starter.startSwi == true)
        {
            if (swi == true)
            {
                swi = false;

                shot();
            }
            if (timer >= effectDisplayTime)
            {
                disableEffect();
            }
        }
    }

    //�r�[��������o���Đ�
    private void shot()
    {
        timer = 0f;
        beamParticle.Stop();

        audio.PlayOneShot(accumurateSound);

        beamParticle.Play();
    }

    //���o������
    private void disableEffect()
    {
        beamParticle.Stop();
    }

    public void OnParticle()
    {
        swi = true;
    }
}
using UnityEngine;
using System.Collections;

public class BeamShooter : MonoBehaviour
{
    [SerializeField] private Starter starter;
    [SerializeField] private RessetButton_Generator ressetButton_Generator;
    [SerializeField] private Unitychan_Animate_Controller unitychan_Animate_Controller;
    [SerializeField] private Kisorachan_Animate_Controller kisorachan_Animate_Controller;
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject LoseText;
    private new AudioSource audio;
    [SerializeField] private AudioClip beamSound;    // �p�[�e�B�N���u�r�[���v�̌��ʉ�
    [SerializeField] private AudioClip explosionSound;    // �����̉�
    [SerializeField] private AudioClip loseSound;    // ���������̌��ʉ�
    [SerializeField] private GameObject unityChan;

    [SerializeField] private ParticleSystem beamParticle;
    [SerializeField] private ParticleSystem heartParticle;
    private bool particleSwi = true;    // �p�[�e�B�N���u�r�[���v������������
    private bool reachSwi = false;    // �p�[�e�B�N���u�r�[���v���͂�����
    private float stretchNum = 0.0f;    // �p�[�e�B�N���u�r�[���v�̒���



    // Use this for initialization
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    // �p�[�e�B�N�����Đ�
    public void OnParticle()
    {
        StartCoroutine(shot());
        StartCoroutine(result());
    }

    // ���@�𒙂߂�p�[�e�B�N�����Đ�
    private IEnumerator shot()
    {
        beamParticle.Stop();

        yield return new WaitForSeconds(1.8f);
        audio.PlayOneShot(beamSound);
        beamParticle.Play();
    }

    // �p�[�e�B�N�����~�߂�
    private void disableEffect()
    {
        beamParticle.Stop();
    }

    // �p�[�e�B�N�����͂����ꍇ
    public void OnParticleCollision(GameObject other)
    {
        if (particleSwi == true)
        {
            particleSwi = false;
            reachSwi = true;

            heartParticle.Play();
            audio.PlayOneShot(explosionSound);

            kisorachan_Animate_Controller.ChangeAnimation();
        }
    }

    // ���ʔ��\
    public IEnumerator result()
    {
        float waitTime = stretchNum + 1.8f;
        yield return new WaitForSeconds(waitTime);
        // �p�[�e�B�N�����͂������͂��ĂȂ����Ŕ��f
        if (reachSwi)
        {
            unitychan_Animate_Controller.ChangeAnimation(true);
            Instantiate(winText, parent.transform);
        }
        else
        {
            waitTime = 0.5f;
            yield return new WaitForSeconds(waitTime);
            audio.PlayOneShot(loseSound);
            unitychan_Animate_Controller.ChangeAnimation(false);
            Instantiate(LoseText, parent.transform);
        }
        // ���Z�b�g�{�^����\��
        ressetButton_Generator.GenerateButton();

    }

    // �r�[���̋������X�V�i��������j
    public void StretchParticle()
    {
        var main = beamParticle.main;
        // �����4.5f�ɐݒ�
        if (stretchNum < 4.5f)
        {
            stretchNum += 0.5f;
        }
        main.startLifetime = stretchNum;
    }
}
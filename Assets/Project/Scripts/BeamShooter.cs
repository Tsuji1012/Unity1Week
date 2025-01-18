using UnityEngine;
using System.Collections;

public class BeamShooter : MonoBehaviour
{
    [SerializeField] private Starter starter;
    [SerializeField] private RessetButtonGenerator ressetButtonGenerator;
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject LoseText;
    private new AudioSource audio;
    [SerializeField] private AudioClip beamSound;
    [SerializeField] private AudioClip explosionSound;
    [SerializeField] private AudioClip loseSound;
    [SerializeField] private GameObject unityChan;

    float timer = 0.0f;
    float effectDisplayTime = 5.0f;
    ParticleSystem beamParticle;
    [SerializeField] ParticleSystem heartParticle;
    private bool swi = false;
    private bool particleSwi = true;
    private bool generateButtonSwi = true;
    private float stretchNum = 0.0f;



    // Use this for initialization
    void Awake()
    {
        beamParticle = GetComponent<ParticleSystem>();

        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間
        timer += Time.deltaTime;

        // 特定の条件で魔法を貯めるパーティクルを再生
        if (starter.startSwi == true)
        {
            if (swi == true)
            {
                swi = false;

                StartCoroutine(shot());
                StartCoroutine(GenerateButton());
            }
            if (timer >= effectDisplayTime)
            {
                disableEffect();
            }
        }
    }

    // 魔法を貯めるパーティクルを再生
    private IEnumerator shot()
    {
        timer = 0f;
        beamParticle.Stop();

        yield return new WaitForSeconds(1.8f);
        audio.PlayOneShot(beamSound);
        beamParticle.Play();

    }

    // パーティクルを消す
    private void disableEffect()
    {
        beamParticle.Stop();
    }

    public void OnParticle()
    {
        swi = true;
    }

    public void OnParticleCollision(GameObject other)
    {
        Animator kisoraChanAnime = other.gameObject.GetComponent<Animator>();
        kisoraChanAnime.SetBool("param_idletoko_big", true);

        if (particleSwi == true)
        {
            particleSwi = false;
            heartParticle.Play();

            ChangeAnimation(true);

            generateButtonSwi = false;

            audio.PlayOneShot(explosionSound);

            ressetButtonGenerator.GenerateButton();
            Instantiate(winText, parent.transform);
        }
    }

    // ビームの距離を更新（長くする）
    public void StretchParticle()
    {
        var main = beamParticle.main;
        stretchNum += 0.5f;
        main.startLifetime = stretchNum;
    }

    public IEnumerator GenerateButton()
    {
        float waitTime = stretchNum + 5.0f;
        yield return new WaitForSeconds(waitTime);
        if (generateButtonSwi == true)
        {
            generateButtonSwi = false;

            ChangeAnimation(false);

            audio.PlayOneShot(loseSound);

            ressetButtonGenerator.GenerateButton();
            Instantiate(LoseText, parent.transform);
        }
    }

    private void ChangeAnimation(bool animationSwi)
    {
        if (animationSwi == true)
        {
            Animator unityChanAnime = unityChan.GetComponent<Animator>();
            unityChanAnime.SetBool("Next", false);
        } else
        {
            Animator unityChanAnime = unityChan.GetComponent<Animator>();
            unityChanAnime.SetBool("Next2", true);
        }
    }
}
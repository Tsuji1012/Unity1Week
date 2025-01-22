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
    [SerializeField] private AudioClip beamSound;    // パーティクル「ビーム」の効果音
    [SerializeField] private AudioClip explosionSound;    // 爆発の音
    [SerializeField] private AudioClip loseSound;    // 負けた時の効果音
    [SerializeField] private GameObject unityChan;

    [SerializeField] private ParticleSystem beamParticle;
    [SerializeField] private ParticleSystem heartParticle;
    private bool particleSwi = true;    // パーティクル「ビーム」が当たったか
    private bool reachSwi = false;    // パーティクル「ビーム」が届いたか
    private float stretchNum = 0.0f;    // パーティクル「ビーム」の長さ



    // Use this for initialization
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    // パーティクルを再生
    public void OnParticle()
    {
        StartCoroutine(shot());
        StartCoroutine(result());
    }

    // 魔法を貯めるパーティクルを再生
    private IEnumerator shot()
    {
        beamParticle.Stop();

        yield return new WaitForSeconds(1.8f);
        audio.PlayOneShot(beamSound);
        beamParticle.Play();
    }

    // パーティクルを止める
    private void disableEffect()
    {
        beamParticle.Stop();
    }

    // パーティクルが届いた場合
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

    // 結果発表
    public IEnumerator result()
    {
        float waitTime = stretchNum + 1.8f;
        yield return new WaitForSeconds(waitTime);
        // パーティクルが届いたか届いてないかで判断
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
        // リセットボタンを表示
        ressetButton_Generator.GenerateButton();

    }

    // ビームの距離を更新（長くする）
    public void StretchParticle()
    {
        var main = beamParticle.main;
        // 上限は4.5fに設定
        if (stretchNum < 4.5f)
        {
            stretchNum += 0.5f;
        }
        main.startLifetime = stretchNum;
    }
}
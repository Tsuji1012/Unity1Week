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
        //経過時間
        timer += Time.deltaTime;

        //特定の条件で魔法を貯めるパーティクルを再生
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

    //魔法を貯めるパーティクルを再生
    private IEnumerator shot()
    {
        timer = 0f;
        beamParticle.Stop();

        yield return new WaitForSeconds(1.8f);
        beamParticle.Play();

    }

    //パーティクルを消す
    private void disableEffect()
    {
        beamParticle.Stop();
    }


    public void OnParticle()
    {
        swi = true;
    }
}
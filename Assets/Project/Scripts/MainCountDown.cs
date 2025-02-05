using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainCountDown : MonoBehaviour
{
    private GameObject subGame_ControllerObj;
    private SubGame_Controller subGame_Controller;
    private GameObject bgm_ControllarObj;
    private BGM_Controllar bgm_Controllar;
    private GameObject particle_ControllerObj;
    private Particle_Controller particle_Controller;


    public TMP_Text timeText;
    public float countDown = 30.0f;
    public bool swi = true;



    // Start is called before the first frame update
    void Start()
    {
        subGame_ControllerObj = GameObject.Find("SubGame_Controller");
        subGame_Controller = subGame_ControllerObj.GetComponent<SubGame_Controller>();

        bgm_ControllarObj = GameObject.Find("BGM_Main");
        bgm_Controllar = bgm_ControllarObj.GetComponent<BGM_Controllar>();

        particle_ControllerObj = GameObject.Find("Particle_Controller");
        particle_Controller = particle_ControllerObj.GetComponent<Particle_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;    // 時間のカウントダウン

        // 時間を表示を更新
        if (swi == true)
        {
            timeText.text = countDown.ToString("f1") + "秒";
        }

        //0.0秒以下になればタイムストップ
        if (countDown <= 0.0f && swi == true)
        {
            swi = false;
            timeText.text = "0.0秒";

            subGame_Controller.DestroySubGame(true);
            subGame_Controller.OffFrame();
            bgm_Controllar.StartCoroutine("FadeOut");

            particle_Controller.StartCoroutine("StartParticle");
            Destroy(this.gameObject);
        }
    }
}

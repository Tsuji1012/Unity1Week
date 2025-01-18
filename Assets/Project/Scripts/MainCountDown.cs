using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainCountDown : MonoBehaviour
{
    private GameObject beamAccumurateObj;
    private GameObject beamAccumurate2Obj;
    private GameObject beamObj;
    private BeamAccumurater beamAccumurater;
    private BeamAccumurater2 beamAccumurater2;
    private BeamShooter beamShooter;
    private GameObject subGameGeneratorObj;
    private SubGameGenerator subGameGenerator;
    private GameObject bgm_ControllarObj;
    private BGM_Controllar bgm_Controllar;

    public TMP_Text timeText;
    public float countDown = 30.0f;
    public bool swi = true;



    // Start is called before the first frame update
    void Start()
    {
        beamAccumurateObj = GameObject.Find("BeamAccumurate");
        beamAccumurate2Obj = GameObject.Find("BeamAccumurate2");
        beamObj = GameObject.Find("Beam");
        beamAccumurater = beamAccumurateObj.GetComponent<BeamAccumurater>();
        beamAccumurater2 = beamAccumurate2Obj.GetComponent<BeamAccumurater2>();
        beamShooter = beamObj.GetComponent<BeamShooter>();

        subGameGeneratorObj = GameObject.Find("SubGameGenerator");
        subGameGenerator = subGameGeneratorObj.GetComponent<SubGameGenerator>();

        bgm_ControllarObj = GameObject.Find("BGM_Controllar");
        bgm_Controllar = bgm_ControllarObj.GetComponent<BGM_Controllar>();
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

            subGameGenerator.DestroySubGame(true);
            bgm_Controllar.StartCoroutine("FadeOut");

            StartCoroutine(StartParticle());
        }
    }

    private IEnumerator StartParticle()
    {
        yield return new WaitForSeconds(2.0f);
        beamAccumurater.OnParticle();
        beamAccumurater2.OnParticle();
        beamShooter.OnParticle();

        Destroy(this.gameObject);
    }
}

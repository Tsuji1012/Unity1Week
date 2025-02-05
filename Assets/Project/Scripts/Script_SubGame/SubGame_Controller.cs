using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubGame_Controller : MonoBehaviour
{
    [SerializeField] private BeamShooter beamShooter;
    [SerializeField] private NagaoshiGame_Generator nagaoshiGame_Generator;
    [SerializeField] private RendaGame_Generator rendaGame_Generator;
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject frame;

    public List<GameObject> instanceList = new List<GameObject>();
    public bool swi = true;
    private int subGameNum;



    // Update is called once per frame
    void Update()
    {
        // ゲームスタートしたら開始
        if (swi)
        {
            swi = false;
            OnFrame();
            subGameNum = Random.Range(1, 3);    // ミニゲームの種類を決定

            // ミニゲームのスクリプトをオンにする
            switch (subGameNum)
            {
                case 1:
                    nagaoshiGame_Generator.swi = true;
                    break;
                case 2:
                    rendaGame_Generator.swi = true;
                    break;
            }
        }
    }

    // 完了したミニゲームの削除
    public void DestroySubGame(bool timeout)
    {
        if (timeout == false)
        {
            swi = true;
        }

        beamShooter.StretchParticle();    // ミニゲームが完了したら、ビームの距離を伸ばす

        // ミニゲーム用に生成したオブジェクトを削除
        foreach (GameObject instance in instanceList)
        {
            Destroy(instance);
        }
        instanceList.Clear();
    }

    // ミニゲームの背景を表示
    public void OnFrame()
    {
        frame.SetActive(true);
    }

    // ミニゲームの背景を削除
    public void OffFrame()
    {
        frame.SetActive(false);
    }
}

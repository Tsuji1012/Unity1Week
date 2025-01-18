using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubGameGenerator : MonoBehaviour
{
    [SerializeField] private Starter starter;
    [SerializeField] private BeamShooter beamShooter;
    [SerializeField] private NagaoshiGameGenerator nagaoshiGameGenerator;
    [SerializeField] private RendaGameGenerator rendaGameGenerator;

    public List<GameObject> instanceList = new List<GameObject>();
    public bool swi = true;
    private int subGameNum;



    // Update is called once per frame
    void Update()
    {
        // ゲームスタートしたら開始
        if (starter.startSwi == true && swi == true)
        {
            swi = false;
            subGameNum = Random.Range(1, 3);    // ミニゲームの種類を決定

            // ミニゲームのスクリプトをオンにする
            switch (subGameNum)
            {
                case 1:
                    nagaoshiGameGenerator.swi = true;
                    break;
                case 2:
                    rendaGameGenerator.swi = true;
                    break;
            }
        }
    }

    public void DestroySubGame(bool timeout)
    {
        if (timeout == false)
        {
            swi = true;
        }

        beamShooter.StretchParticle();    // ミニゲーム終了後、ビームの距離を伸ばす

        // ミニゲーム用に生成したオブジェクトを削除
        foreach (GameObject instance in instanceList)
        {
            Destroy(instance);
        }
        instanceList.Clear();
    }
}

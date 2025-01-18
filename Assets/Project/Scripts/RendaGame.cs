using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendaGame : MonoBehaviour
{
    private GameObject subgameGeneratorObj;
    private SubGameGenerator subGameGenerator;

    [SerializeField] private int rendaNum;



    // Start is called before the first frame update
    void Start()
    {
        subgameGeneratorObj = GameObject.Find("SubGameGenerator");
        subGameGenerator = subgameGeneratorObj.GetComponent<SubGameGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 連打しなければならない回数が0になればミニゲームを削除
        if (rendaNum <= 0)
        {
            subGameGenerator.DestroySubGame(false);
        }
    }

    // ボタンを押すと連打しなければならない回数を減らす
    public void OnClick()
    {
        rendaNum -= 1;
    }
}

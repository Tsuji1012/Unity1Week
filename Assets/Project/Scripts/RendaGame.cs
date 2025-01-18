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
        // �A�ł��Ȃ���΂Ȃ�Ȃ��񐔂�0�ɂȂ�΃~�j�Q�[�����폜
        if (rendaNum <= 0)
        {
            subGameGenerator.DestroySubGame(false);
        }
    }

    // �{�^���������ƘA�ł��Ȃ���΂Ȃ�Ȃ��񐔂����炷
    public void OnClick()
    {
        rendaNum -= 1;
    }
}

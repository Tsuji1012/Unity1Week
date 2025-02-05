using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendaGame : MonoBehaviour
{
    private GameObject subGame_ControllerObj;
    private SubGame_Controller subGame_Controller;

    [SerializeField] private int rendaNum;



    // Start is called before the first frame update
    void Start()
    {
        subGame_ControllerObj = GameObject.Find("SubGame_Controller");
        subGame_Controller = subGame_ControllerObj.GetComponent<SubGame_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        // �A�ł��Ȃ���΂Ȃ�Ȃ��񐔂�0�ɂȂ�΃~�j�Q�[�����폜
        if (rendaNum <= 0)
        {
            subGame_Controller.DestroySubGame(false);
        }
    }

    // �{�^���������ƘA�ł��Ȃ���΂Ȃ�Ȃ��񐔂����炷
    public void OnClick()
    {
        rendaNum -= 1;
    }
}

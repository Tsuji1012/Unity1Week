using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagaoshiGame_Generator : MonoBehaviour
{
    [SerializeField] private GameObject Nagaoshi_OutCircle;
    [SerializeField] private GameObject Nagaoshi_InCircle;
    [SerializeField] private GameObject Nagaoshi_Text;
    [SerializeField] private GameObject parent;
    private GameObject subGame_ControllerObj;
    private SubGame_Controller subGame_Controller;

    public bool swi = false;



    // Start is called before the first frame update
    void Start()
    {
        subGame_ControllerObj = GameObject.Find("SubGame_Controller");
        subGame_Controller = subGame_ControllerObj.GetComponent<SubGame_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        // �~�j�Q�[���u�������v�𐶐�
        if (swi == true)
        {
            swi = false;

            // �~�j�Q�[���u�������v�ɕK�v�ȃI�u�W�F�N�g�𐶐����ASubGameGenerator�̃C���X�^���X���X�g�ɒǉ�
            subGame_Controller.instanceList.Add(Instantiate(Nagaoshi_OutCircle, parent.transform));
            subGame_Controller.instanceList.Add(Instantiate(Nagaoshi_InCircle, parent.transform));
            subGame_Controller.instanceList.Add(Instantiate(Nagaoshi_Text, parent.transform));
        }
    }

    
}

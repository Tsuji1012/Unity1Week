using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagaoshiGameGenerator : MonoBehaviour
{
    [SerializeField] private GameObject frame;
    [SerializeField] private GameObject NagaoshiOutCircle;
    [SerializeField] private GameObject NagaoshiInCircle;
    [SerializeField] private GameObject NagaoshiText;
    [SerializeField] private GameObject parent;
    private GameObject subgameGeneratorObj;
    private SubGameGenerator subgameGenerator;

    public bool swi = false;



    // Start is called before the first frame update
    void Start()
    {
        subgameGeneratorObj = GameObject.Find("SubGameGenerator");
        subgameGenerator = subgameGeneratorObj.GetComponent<SubGameGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        // �~�j�Q�[���u�������v�𐶐�
        if (swi == true)
        {
            swi = false;

            // �~�j�Q�[���u�������v�ɕK�v�ȃI�u�W�F�N�g�𐶐����ASubGameGenerator�̃C���X�^���X���X�g�ɒǉ�
            subgameGenerator.instanceList.Add(Instantiate(frame, this.gameObject.transform.position, this.gameObject.transform.rotation));
            subgameGenerator.instanceList.Add(Instantiate(NagaoshiOutCircle, new Vector3(0.0f, 1.15f, -7.5f), Quaternion.Euler(3.5f, 0, 0)));
            subgameGenerator.instanceList.Add(Instantiate(NagaoshiInCircle, new Vector3(0.0f, 1.15f, -7.5f), Quaternion.Euler(3.5f, 0, 0)));
            subgameGenerator.instanceList.Add(Instantiate(NagaoshiText, parent.transform));
        }
    }

    
}

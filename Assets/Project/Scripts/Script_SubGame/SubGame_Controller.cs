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
        // �Q�[���X�^�[�g������J�n
        if (swi)
        {
            swi = false;
            OnFrame();
            subGameNum = Random.Range(1, 3);    // �~�j�Q�[���̎�ނ�����

            // �~�j�Q�[���̃X�N���v�g���I���ɂ���
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

    // ���������~�j�Q�[���̍폜
    public void DestroySubGame(bool timeout)
    {
        if (timeout == false)
        {
            swi = true;
        }

        beamShooter.StretchParticle();    // �~�j�Q�[��������������A�r�[���̋�����L�΂�

        // �~�j�Q�[���p�ɐ��������I�u�W�F�N�g���폜
        foreach (GameObject instance in instanceList)
        {
            Destroy(instance);
        }
        instanceList.Clear();
    }

    // �~�j�Q�[���̔w�i��\��
    public void OnFrame()
    {
        frame.SetActive(true);
    }

    // �~�j�Q�[���̔w�i���폜
    public void OffFrame()
    {
        frame.SetActive(false);
    }
}

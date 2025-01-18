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
        // �Q�[���X�^�[�g������J�n
        if (starter.startSwi == true && swi == true)
        {
            swi = false;
            subGameNum = Random.Range(1, 3);    // �~�j�Q�[���̎�ނ�����

            // �~�j�Q�[���̃X�N���v�g���I���ɂ���
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

        beamShooter.StretchParticle();    // �~�j�Q�[���I����A�r�[���̋�����L�΂�

        // �~�j�Q�[���p�ɐ��������I�u�W�F�N�g���폜
        foreach (GameObject instance in instanceList)
        {
            Destroy(instance);
        }
        instanceList.Clear();
    }
}

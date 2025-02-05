using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagaoshiGame : MonoBehaviour
{
    private GameObject subGame_ControllerObj;
    private SubGame_Controller subGame_Controller;
    private new AudioSource audio;
    [SerializeField] private AudioClip nagaoshiSound;

    private Vector3 scale;
    private bool nagaoshiSwi = true;


    // Start is called before the first frame update
    void Start()
    {
        subGame_ControllerObj = GameObject.Find("SubGame_Controller");
        subGame_Controller = subGame_ControllerObj.GetComponent<SubGame_Controller>();

        audio = GetComponent<AudioSource>();

        scale = this.transform.localScale;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            // ���������Ă���ԁAOutCircle�����������Ă���
            if (scale.x > 2.0f)
            {
                if (nagaoshiSwi == true)
                {
                    nagaoshiSwi = false;
                    audio.PlayOneShot(nagaoshiSound);
                }

                scale.x -= 0.028f;
                scale.y -= 0.028f;

                this.transform.localScale = scale;
            } else    // �������Ȃ�����~�j�Q�[�����폜
            {
                subGame_Controller.DestroySubGame(false);
            }
        } else    // ���������r�₦������ʉ��̍Đ����~�߂�
        {
            nagaoshiSwi = true;
            audio.Stop();
        }
    }
}

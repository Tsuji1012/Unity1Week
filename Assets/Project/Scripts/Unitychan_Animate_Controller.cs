using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unitychan_Animate_Controller : MonoBehaviour
{
    [SerializeField] private Starter starter;

    private Animator anime;
    private bool swi = true;



    // Start is called before the first frame update
    void Start()
    {
        anime = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���@�𗭂߂�A�j���[�V�����ɕύX
        if (starter.startSwi && swi)
        {
            swi = false;
            anime.SetBool("Charge", true);
        }
    }

    // �r�[�����͂������͂��Ȃ���������Unity�����̃A�j���[�V������ύX
    public void ChangeAnimation(bool animationSwi)
    {
        if (animationSwi == true)
        {
            anime.SetBool("Fire", true);
        }
        else
        {
            anime.SetBool("NotFire", true);
        }
    }
}

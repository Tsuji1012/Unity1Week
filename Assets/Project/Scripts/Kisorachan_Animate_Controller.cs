using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kisorachan_Animate_Controller : MonoBehaviour
{

    private Animator anime;



    // �r�[�����͂�����AKisora�����̃A�j���[�V������ύX
    public void ChangeAnimation()
    {
        anime = gameObject.GetComponent<Animator>();
        anime.SetBool("param_idletoko_big", true);    // kisora�����̃A�j���[�V������ύX
    }
}

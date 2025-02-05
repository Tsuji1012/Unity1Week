using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kisorachan_Animate_Controller : MonoBehaviour
{

    private Animator anime;



    // ビームが届いたら、Kisoraちゃんのアニメーションを変更
    public void ChangeAnimation()
    {
        anime = gameObject.GetComponent<Animator>();
        anime.SetBool("param_idletoko_big", true);    // kisoraちゃんのアニメーションを変更
    }
}

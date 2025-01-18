using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate_Controllar : MonoBehaviour
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
        //魔法を放つアニメーションに変更
        if (starter.startSwi == true && swi == true)
        {
            swi = false;
            anime.SetBool("Next", true);
        }
    }
}

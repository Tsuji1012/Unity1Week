using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Controllar : MonoBehaviour
{
    [SerializeField] private Starter starter;

    private new AudioSource audio;
    [SerializeField] private AudioClip bgm;
    private bool swi = true;


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // BGP‚ğÁ‹AŸ‚ÌBGP‚ğÄ¶
        if (starter.startSwi == true && swi == true)
        {
            swi = false;

            audio.Stop();
            audio.clip = bgm;
            audio.Play();
        }
    }
}

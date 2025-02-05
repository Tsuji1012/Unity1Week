using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Controllar : MonoBehaviour
{
    [SerializeField] private AudioSource audio;



    public IEnumerator FadeOut()
    {
        while(audio.volume > 0)
        {
            audio.volume -= 0.01f;
            yield return new WaitForSeconds(0.03f);
        }
    }
}

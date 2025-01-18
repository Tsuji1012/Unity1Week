using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [System.NonSerialized]
    public bool startSwi = false;
    [SerializeField] private AudioClip startSound;
    [SerializeField] private GameObject kisoraChan;
    [SerializeField] private GameObject canvasObj;


    //ボタンを押した時、タイトル画面のUIを消去&キソラちゃん表示
    public void OnClick()
    {
        startSwi = true;
        AudioSource.PlayClipAtPoint(startSound, this.transform.position);
        kisoraChan.SetActive(true);
        canvasObj.SetActive(false);
    }
}

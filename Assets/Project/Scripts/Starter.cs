using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{
    [SerializeField] private AudioSource audio;



    //ボタンを押した時、タイトル画面のUIを消去&キソラちゃん表示
    public void OnClick()
    {
        audio.PlayOneShot(audio.clip);
        SceneManager.LoadScene("MainScene");
    }
}

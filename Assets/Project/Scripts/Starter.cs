using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{
    [SerializeField] private AudioSource audio;



    //�{�^�������������A�^�C�g����ʂ�UI������&�L�\�������\��
    public void OnClick()
    {
        audio.PlayOneShot(audio.clip);
        SceneManager.LoadScene("MainScene");
    }
}

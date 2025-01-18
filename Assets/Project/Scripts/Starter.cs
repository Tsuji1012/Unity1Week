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


    //�{�^�������������A�^�C�g����ʂ�UI������&�L�\�������\��
    public void OnClick()
    {
        startSwi = true;
        AudioSource.PlayClipAtPoint(startSound, this.transform.position);
        kisoraChan.SetActive(true);
        canvasObj.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controllar : MonoBehaviour
{
    [SerializeField] private Starter starter;
    [SerializeField] private GameObject startCamera;
    [SerializeField] private GameObject mainCamera;



    // Update is called once per frame
    void Update()
    {
        //カメラを変える
        if (starter.startSwi == true)
        {
            startCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
    }
}

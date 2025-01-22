using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessetButton_Generator : MonoBehaviour
{
    [SerializeField] private GameObject ressetButton;
    [SerializeField] private GameObject parent;



    // リセットボタンを生成
    public void GenerateButton()
    {
        Instantiate(ressetButton, parent.transform);
    }
}

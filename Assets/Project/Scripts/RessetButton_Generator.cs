using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessetButton_Generator : MonoBehaviour
{
    [SerializeField] private GameObject ressetButton;
    [SerializeField] private GameObject parent;



    // ���Z�b�g�{�^���𐶐�
    public void GenerateButton()
    {
        Instantiate(ressetButton, parent.transform);
    }
}

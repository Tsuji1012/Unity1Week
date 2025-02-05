using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGenerator : MonoBehaviour
{
    [SerializeField] private GameObject countDown;
    [SerializeField] private GameObject parent;

    private bool swi = true;

    // Update is called once per frame
    void Update()
    {
        if (swi)
        {
            swi = false;

            Instantiate(countDown, parent.transform);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGenerator : MonoBehaviour
{
    [SerializeField] private Starter starter;
    [SerializeField] private GameObject countDown;
    [SerializeField] private GameObject parent;

    private bool swi = true;

    // Update is called once per frame
    void Update()
    {
        // êßå¿éûä‘Çï\é¶
        if (starter.startSwi == true && swi == true)
        {
            swi = false;

            Instantiate(countDown, parent.transform);
        }
    }
}

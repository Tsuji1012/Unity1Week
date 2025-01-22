using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendaGame_Generator : MonoBehaviour
{
    [SerializeField] private GameObject RendaButton;
    [SerializeField] private GameObject RendaText;
    [SerializeField] private GameObject parent;
    private GameObject subGame_ControllerObj;
    private SubGame_Controller subGame_Controller;

    public bool swi = false;



    // Start is called before the first frame update
    void Start()
    {
        subGame_ControllerObj = GameObject.Find("SubGame_Controller");
        subGame_Controller = subGame_ControllerObj.GetComponent<SubGame_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        // ミニゲーム「連打」を生成
        if (swi == true)
        {
            swi = false;

            // ミニゲーム「連打」に必要なオブジェクトを生成し、SubGameGeneratorのインスタンスリストに追加
            subGame_Controller.instanceList.Add(Instantiate(RendaButton, parent.transform));
            subGame_Controller.instanceList.Add(Instantiate(RendaText, parent.transform));
        }
    }

    
}

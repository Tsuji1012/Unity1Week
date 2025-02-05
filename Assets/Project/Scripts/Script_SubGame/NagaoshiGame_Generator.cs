using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagaoshiGame_Generator : MonoBehaviour
{
    [SerializeField] private GameObject Nagaoshi_OutCircle;
    [SerializeField] private GameObject Nagaoshi_InCircle;
    [SerializeField] private GameObject Nagaoshi_Text;
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
        // ミニゲーム「長押し」を生成
        if (swi == true)
        {
            swi = false;

            // ミニゲーム「長押し」に必要なオブジェクトを生成し、SubGameGeneratorのインスタンスリストに追加
            subGame_Controller.instanceList.Add(Instantiate(Nagaoshi_OutCircle, parent.transform));
            subGame_Controller.instanceList.Add(Instantiate(Nagaoshi_InCircle, parent.transform));
            subGame_Controller.instanceList.Add(Instantiate(Nagaoshi_Text, parent.transform));
        }
    }

    
}

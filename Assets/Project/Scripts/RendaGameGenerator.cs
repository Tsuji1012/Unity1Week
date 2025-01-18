using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendaGameGenerator : MonoBehaviour
{
    [SerializeField] private GameObject frame;
    [SerializeField] private GameObject RendaButton;
    [SerializeField] private GameObject RendaText;
    [SerializeField] private GameObject parent;
    private GameObject subgameGeneratorObj;
    private SubGameGenerator subgameGenerator;

    public bool swi = false;



    // Start is called before the first frame update
    void Start()
    {
        subgameGeneratorObj = GameObject.Find("SubGameGenerator");
        subgameGenerator = subgameGeneratorObj.GetComponent<SubGameGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        // ミニゲーム「連打」を生成
        if (swi == true)
        {
            swi = false;

            // ミニゲーム「連打」に必要なオブジェクトを生成し、SubGameGeneratorのインスタンスリストに追加
            subgameGenerator.instanceList.Add(Instantiate(frame, this.gameObject.transform.position, this.gameObject.transform.rotation));
            subgameGenerator.instanceList.Add(Instantiate(RendaButton, parent.transform));
            subgameGenerator.instanceList.Add(Instantiate(RendaText, parent.transform));
        }
    }

    
}

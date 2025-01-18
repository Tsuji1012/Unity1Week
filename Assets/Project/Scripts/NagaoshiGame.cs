using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagaoshiGame : MonoBehaviour
{
    private GameObject subgameGeneratorObj;
    private SubGameGenerator subGameGenerator;
    private new AudioSource audio;
    [SerializeField] private AudioClip nagaoshiSound;

    private Vector3 scale;
    private bool nagaoshiSwi = true;


    // Start is called before the first frame update
    void Start()
    {
        subgameGeneratorObj = GameObject.Find("SubGameGenerator");
        subGameGenerator = subgameGeneratorObj.GetComponent<SubGameGenerator>();

        audio = GetComponent<AudioSource>();

        scale = this.transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            // í∑âüÇµÇµÇƒÇ¢ÇÈä‘ÅAOutCircleÇè¨Ç≥Ç≠ÇµÇƒÇ¢Ç≠
            if (scale.x > 0.2f)
            {
                if (nagaoshiSwi == true)
                {
                    nagaoshiSwi = false;
                    audio.PlayOneShot(nagaoshiSound);
                }

                scale.x -= 0.0028f;
                scale.y -= 0.0028f;

                this.transform.localScale = scale;
            } else    // è¨Ç≥Ç≠Ç»Ç¡ÇΩÇÁÉ~ÉjÉQÅ[ÉÄÇçÌèú
            {
                subGameGenerator.DestroySubGame(false);
            }
        } else    // í∑âüÇµÇ™ìrê‚Ç¶ÇΩÇÁå¯â âπÇÃçƒê∂Çé~ÇﬂÇÈ
        {
            nagaoshiSwi = true;
            audio.Stop();
        }
    }
}

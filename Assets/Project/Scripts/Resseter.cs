using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resseter : MonoBehaviour
{
    // シーンを再読み込みしてリセット
    public void OnClick()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
        Destroy(this.gameObject);
    }
}

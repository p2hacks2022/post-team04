using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowManager : MonoBehaviour
{
    private GameObject[] windowBox;

    void Update()
    {
        windowBox = GameObject.FindGameObjectsWithTag("glass");
        
        Debug.Log("窓の数：" + windowBox.Length);

        if (windowBox.Length == 0)
        {
            Debug.Log("クリア！");
        }
    }
}

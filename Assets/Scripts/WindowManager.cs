using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class WindowManager : MonoBehaviour
{
    [SerializeField]
    GameObject clearUI;

    private GameObject[] windowBox;

    void Update()
    {
        windowBox = GameObject.FindGameObjectsWithTag("glass");

        print("窓の数：" + windowBox.Length);

        if (windowBox.Length == 0)
        {
            clearUI.SetActive(true);
            Debug.Log("クリア！");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScript_MGSF : MonoBehaviour {

    public GameObject canvas;
    void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame);	
    } 
    void StartGame() {  
        SceneManager.LoadScene("SampleScene"); 
        Destroy(canvas);
    }
}
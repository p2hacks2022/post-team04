using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;//スクリプトの先頭に書く

public class atarihantei : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision c)
    { //何かと当たったら1回呼ばれる
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);//シーン変更
    }

}
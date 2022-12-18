using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class GameManager : MonoBehaviour
{
    [SerializeField] float playTime1;
    float playTime2;
    [SerializeField] Text timeCdText;
    [SerializeField] Text timeCuText;
    [SerializeField] TextMeshProUGUI timeCdTMP;
    [SerializeField] TextMeshProUGUI timeCuTMP;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        playTime1 -= Time.deltaTime; //時間経過で減算
        timeCdText.text = playTime1.ToString("F1"); //四捨五入して小数1桁まで表示
        timeCdTMP.text = playTime1.ToString("F1");
 
        playTime2 += Time.deltaTime; //時間経過で加算
        timeCuText.text = playTime2.ToString("F1");
        timeCuTMP.text = playTime2.ToString("F1");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour 
{
    public TextMeshProUGUI sc;
    public ArabaHareket arabaHareket;

    
    void Start()
    {

    }
    void Update()
    {
        sc.text = arabaHareket.puan.ToString();
    }
}



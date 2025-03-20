using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Score_Handler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_scoreText;
    public void Awake()
    {
        string a = "CORRECTLY IDENTIFIED: ";
        string b = ScoreManager.Instance.Score.ToString();

        m_scoreText.text = a + b;
    }


}

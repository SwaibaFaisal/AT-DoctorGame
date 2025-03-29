using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_currentQuestionText;
    [SerializeField] TextMeshProUGUI m_currentAnswerText;
    int m_index;
    DialogueBox m_parentScript;

    public void Awake()
    {
        m_parentScript = this.GetComponentInParent<DialogueBox>();
        if(m_parentScript == null)
        {
            print("parent dialogue box not found");
        }
    }
    public void SetQuestionText(string _text)
    {
        m_currentQuestionText.text = _text;
    }

    public void SetAnswerText(string _text)
    {
        m_currentAnswerText.text = _text;
    }

    public void OnClicked()
    {

    }

    public int Index { get { return m_index; } set { m_index = value; } }

}

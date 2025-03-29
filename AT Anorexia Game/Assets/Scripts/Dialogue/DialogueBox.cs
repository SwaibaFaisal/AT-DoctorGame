using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] List<Button> m_questionButtons;
    [SerializeField] List<string> m_currentQuestionStrings;
    [SerializeField] List<string> m_currentAnswerStrings;
    [SerializeField] TextMeshProUGUI m_currentAnswerText;
    [SerializeField] GameObject m_buttonsParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLists()
    {
        
    }

    public void SetButtons()
    {
        for(int i = 0; i < m_questionButtons.Count; i++)
        {
            if (m_questionButtons[i].GetComponent<QuestionButton>() != null)
            {
                QuestionButton m_script = m_questionButtons[i].GetComponent<QuestionButton>();
                m_script.Index = i;     
            }
         
        }
    }

    public void SetButtonsActive(bool _active)
    {
        m_buttonsParent.SetActive(_active);
    }

    public void DisplayAnswerText(string _text)
    {
       m_currentAnswerText.text = _text;
    }

    public void QuestionButtonClicked(int _index)
    {
        SetButtonsActive(false);
    }

    public void BackToQuestions()
    {

    }

}

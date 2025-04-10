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
    [SerializeField] GameObject m_answerParent;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    public void StartSequence()
    {

        SetQuestionButtonData();
        SetButtonsActive(true);

    }
   
    public void SetLists(List<string> _questions, List<string> _answers)
    {
        m_currentQuestionStrings.Clear();
        m_currentAnswerStrings.Clear();
        m_currentQuestionStrings = _questions;
        m_currentAnswerStrings = _answers;
    }

    public void SetQuestionButtonData()
    {
        for(int i = 0; i < m_questionButtons.Count; i++)
        {
            if (m_questionButtons[i].GetComponent<QuestionButton>() != null)
            {
                QuestionButton m_script = m_questionButtons[i].GetComponent<QuestionButton>();
                m_script.Index = i;
                m_script.SetQuestionText(m_currentQuestionStrings[i]);
            }
         
        }
    }

    public void SetButtonsActive(bool _active)
    {
        m_buttonsParent.SetActive(_active);
        m_answerParent.SetActive(!_active);
    }

    public void DisplayAnswerText(string _text)
    {
       m_currentAnswerText.text = _text;
    }

    public void QuestionButtonClicked(int _index)
    {
        SetButtonsActive(false);
        m_currentAnswerText.text = m_currentAnswerStrings[_index];
    }

    public void BackToQuestions()
    {
        m_currentAnswerText.text = " ";
        SetButtonsActive(true);
    }

    public void ExitButtonPressed()
    {
        BackToQuestions();
        this.gameObject.SetActive(false);
    }
}

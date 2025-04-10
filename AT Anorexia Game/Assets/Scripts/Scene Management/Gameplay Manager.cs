using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameplayManager : SceneObject
{

    [SerializeField] DialogueBox m_dialogueBoxScript;

    [SerializeField] List<PatientObject> m_patientObjects;
    
    [SerializeField] int m_currentPatientIndex;

    // Start is called before the first frame update
    void Start()
    {
        SetupSequence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendDataToManagers(PatientObject _currentPatientData)
    {
        m_dialogueBoxScript.SetLists(_currentPatientData.QuestionText, _currentPatientData.AnswerText);
        m_dialogueBoxScript.StartSequence();
    }

    public void SetupSequence()
    {
        m_currentPatientIndex = 0;
        SendDataToManagers(m_patientObjects[m_currentPatientIndex]);
    }

    public void CheckForReferral(bool _answer)
    {
        print("testing");

        if (_answer == m_patientObjects[m_currentPatientIndex].Refer)
        {
            print("answer correct");
            return ;
        }
        else
        {
            print("try again loser");
        }

        
    }

}

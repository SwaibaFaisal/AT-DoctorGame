using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checklist : MonoBehaviour
{
    [SerializeField] List<GameObject> m_checkBoxList;
    int m_localScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChecklistSubmitted()
    {
        for(int i = 0; i < m_checkBoxList.Count; i++)
        {

            if (m_checkBoxList[i].GetComponent<CheckBox>() != null)
            {
                CheckBox _script = m_checkBoxList[i].GetComponent<CheckBox>();

                if (_script.CorrectAnswer == _script.Selected)
                {
                    ScoreManager.Instance.AddScore(1);
                }
            }
        }
    }
}

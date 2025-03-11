using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNewWindow : Clickable
{
    [SerializeField] GameObject m_window;
    


    void Start()
    {
        m_window.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnClicked()
    {
        base.OnClicked();

        if(Selected)
        {
            m_window.SetActive(true);
        }
        else
        {
            m_window.SetActive(false);
        }

    }
}

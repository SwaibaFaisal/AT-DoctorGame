using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNewWindow : Clickable
{
    [SerializeField] GameObject m_window;
    [SerializeField] bool m_toggle;


    void Start()
    {
        m_window.SetActive(false);
    }

    // Update is called once per frame
    public override void Update()
    {
     

       m_selected = m_window.activeSelf;
       base.Update();
    }

    public override void OnClicked()
    {

        if(!m_toggle)
        {
            if(!m_selected)
            {
                base.OnClicked();
                m_window.SetActive(!m_window.activeSelf);
            }
        }
        else
        {
            base.OnClicked();
            m_window.SetActive(!m_window.activeSelf);
        }

        
    }
}

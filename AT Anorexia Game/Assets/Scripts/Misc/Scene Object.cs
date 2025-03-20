using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObject : MonoBehaviour
{

    [SerializeField] protected bool m_isActive;


    public void SetObjectActive(bool _active)
    {
        this.gameObject.SetActive(_active);
        m_isActive = _active;
    }

    public virtual void Awake()
    {
        SetObjectActive(m_isActive);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorScript : MonoBehaviour
{
    Vector2 m_cursorScreenPosition;
    Camera m_camera;
    [SerializeField] LayerMask m_clickableLayer;
    Clickable m_hoveredItemScript;

    // Start is called before the first frame update
    void Awake()
    {
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _mouseposition = Input.mousePosition;
        Vector2 _worldPosition = m_camera.ScreenToWorldPoint(_mouseposition);

        Ray ray = m_camera.ScreenPointToRay(_mouseposition);

        RaycastHit2D hit = Physics2D.GetRayIntersection(ray, 100f, m_clickableLayer);

        if(hit.collider != null)
        {
            if(hit.collider.GetComponentInParent<Clickable>()!= null)
            {
                m_hoveredItemScript = hit.collider.GetComponentInParent<Clickable>();
            }
        }
        else
        {
            m_hoveredItemScript = null;
        }
      
    }

    public void OnClick(InputAction.CallbackContext _context)
    {
        if(_context.started)
        {
           if(m_hoveredItemScript != null) 
           {
                m_hoveredItemScript.OnClicked();
           }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZ_ObjectDrop : MonoBehaviour
{
    public GameObject m_target;
    bool m_droppable=false;

    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == m_target.gameObject.tag)
        {
            m_droppable = true;
            Debug.Log("Objetivo correcto");
        }

        else if (collisionInfo.collider.tag != m_target.gameObject.tag)
        {
            m_droppable = false;
            Debug.Log("Objetivo incorrecto");
        }
    }
}

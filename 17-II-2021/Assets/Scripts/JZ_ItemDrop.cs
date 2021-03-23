using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZ_ItemDrop : MonoBehaviour
{
    public GameObject m_target;
    //public bool m_drop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == m_target.gameObject.name)
        {
            //m_drop = true;
            Debug.Log("Objetivo correcto");
        }

        else if (collisionInfo.collider.name != m_target.gameObject.name)
        {
            //m_drop = false;
            Debug.Log("Objetivo incorrecto");
        }
    }

}

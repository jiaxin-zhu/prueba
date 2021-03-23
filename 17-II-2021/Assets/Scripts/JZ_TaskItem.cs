using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZ_TaskItem : MonoBehaviour
{
    public int m_taskNumber;
    public JZ_TaskManager m_taskM;
    public string m_itemName;
    public JZ_Grabable m_grabable;

    void Update()
    {
        if (m_grabable.m_child.GetComponent<Rigidbody>().isKinematic == true) //checks if the object is being grabbed
        {
            if (!m_taskM.m_taskCompleted[m_taskNumber] && m_taskM.m_tasks[m_taskNumber].gameObject.activeSelf) //checks that the task assigned to the object is still active
            {
                //m_taskM.m_itemCollected == m_itemName; //sends the name ob the object to grab to the task manager
            }
        }
    }

}

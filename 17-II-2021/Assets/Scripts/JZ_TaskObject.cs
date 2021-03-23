using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZ_TaskObject : MonoBehaviour
{
    public int m_taskNumber; //number of task we are completing
    public JZ_TaskManager m_taskM; //reference to task manager
    public string m_startText;
    public string m_endText;
    public bool m_isPickupTask; //variable to say if it is an pick up task
    public string m_item; //object you have to pick up

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isPickupTask) //check the item that we grabbed
        {
            if (m_taskM.m_itemCollected == m_item) //if it's the same item from the task
            {
                m_taskM.m_itemCollected = null; 
                EndTask();
            }
        }
    }

    //activates the task
    public void StartTask()
    {
        //before starting the task, checks if the previous task was completed
        if ((m_taskNumber>0) && (m_taskM.m_taskCompleted[m_taskNumber - 1] = false))
        {
            Debug.Log("Previous task uncompleted");
        }
        else
        {
            Debug.Log(m_startText); //shows start text when the task starts
        }
          
    }

    //deactivates the task when it's completed
    public void EndTask()
    {
        if (m_taskNumber <= m_taskM.m_tasks.Length)
        {
            m_taskM.m_taskCompleted[m_taskNumber] = true; //goes to the task manager, and sets the value of the task to true
            gameObject.SetActive(false); //deactivates the task object
            Debug.Log(m_endText); //shows a end text when the task is completed
        }
        else if (m_taskNumber > m_taskM.m_tasks.Length)
        {
            Debug.Log("All tasks are completed!");
        }
    }
}

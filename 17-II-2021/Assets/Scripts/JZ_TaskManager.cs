using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZ_TaskManager : MonoBehaviour
{

    public JZ_TaskObject[] m_tasks; //array of tasks
    public bool[] m_taskCompleted; //array of completed tasks
    public string m_itemCollected; //string of the object collected

    // Start is called before the first frame update
    void Start()
    {
        m_taskCompleted = new bool[m_tasks.Length]; //right from the start, both arrays have the same size
        m_tasks[0].StartTask();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

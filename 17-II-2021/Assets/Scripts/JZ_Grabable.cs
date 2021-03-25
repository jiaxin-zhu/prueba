
using UnityEngine;

public class JZ_Grabable : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    private float m_distance = 3f; //raycast radius
    public GameObject m_child; //gameobject that we are grabbing
    public Transform m_parent;//parent to which we attach the child
    public bool carryObject;//if the object is being carried
    //public JZ_ItemDrop m_dropabble;//if the object can be dropped or not

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
            RaycastHit hit;
            //position of camera and take the forward direction 
            Vector3 direction = new Vector3(0, -1, 1);
            Ray ray = new Ray(transform.position, direction);
            if(Physics.Raycast(ray, out hit, m_distance))
            {
                Debug.Log(hit.collider.tag);
                //compare tag, declare a variable for tag
                //check if the script is correct (trygetcomponent), checks the tag from main object, when play it asigns the object to grab, then calls the methods within the object script
                if (hit.collider.tag == "Object") //if the raycast hits an object
                
                {
                    //in the script of the object, create a variable to check if the object is grabable, another variable to asign name
                    //check if carry object is false, carry the object while pressing the button
                    //if I have two hands, check if one of the hands is free check to attach, if the object tag is correct, if the object has correct script, correct distance, object is grabable
                    carryObject = true;//we are carrying the object
                    if (carryObject)
                    {
                        m_child = hit.collider.gameObject;
                        m_child.transform.SetParent(m_parent);//set the new parent
                        m_child.gameObject.transform.position = m_parent.position;//set the child's transform to the parent's transform
                        m_child.GetComponent<Rigidbody>().isKinematic = true;//deactivate the physics and collisions
                        m_child.GetComponent<Rigidbody>().useGravity = false;//deactivate gravity
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            carryObject = false; //we aren't carrying the object  
        }

        if (!carryObject)
        {
            m_parent.DetachChildren();
            m_child.GetComponent<Rigidbody>().isKinematic = false;
            m_child.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}


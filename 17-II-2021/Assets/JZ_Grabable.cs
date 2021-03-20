
using UnityEngine;

public class JZ_Grabable : MonoBehaviour
{
    public float m_radius = 4f; //raycast radius
    public GameObject m_child; //gameobject that we are grabbing
    public Transform m_parent;//parent to which we attach the child
    public bool carryObject;//if the object is being carried
    public bool m_droppable;//if the object can be dropped or not

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
            RaycastHit hit;
            Vector3 projection = new Vector3(0, -1, 1);
            Ray directionRay = new Ray(transform.position, projection);
            if(Physics.Raycast(directionRay, out hit, m_radius))
            {
                if (hit.collider.tag == "Object") //if the raycast hits an object
                {
                    carryObject = true;//we are carrying the object
                    if (carryObject == true)
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

        if (carryObject == false)
        {
            m_parent.DetachChildren();
            m_child.GetComponent<Rigidbody>().isKinematic = false;
            m_child.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}


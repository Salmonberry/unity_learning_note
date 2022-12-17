using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MouseEventOnScreenClicked:UnityEvent<Vector3>
{
    
}
public class MouseEventManager : MonoBehaviour
{

    public MouseEventOnScreenClicked mouseEventOnScreenClicked;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
           

            if (Physics.Raycast(ray,out hit)&&hit.collider.gameObject!=null)
            { Debug.Log(hit.collider);
              Debug.DrawLine(ray.origin,hit.point,Color.red,10);   
              Debug.Log(Input.mousePosition);
              mouseEventOnScreenClicked.Invoke(hit.point);
            }
           
        }
        
    }
    
    
    
}

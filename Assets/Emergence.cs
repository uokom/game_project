using UnityEngine;
public class Emergence : MonoBehaviour
{
    public Camera cam;
    public GameObject obj;
    public GameObject bullet;

    Vector3 beforePos;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
                try
                {
                    beforePos = obj.transform.position;
                    obj.transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
                    obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, beforePos.z);
                    obj.SetActive(true);
                
                }

                catch (MissingReferenceException e)
                {
                    Destroy(gameObject);
                }
                
               
            
        }else
        {
            obj.SetActive(false);
        }
    }
}
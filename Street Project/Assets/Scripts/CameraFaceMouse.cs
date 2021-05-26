using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFaceMouse : MonoBehaviour
{
    Vector3 screenPosition;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        direction = Input.mousePosition - screenPosition;

        float degrees = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion radiansRotation = Quaternion.AngleAxis((-degrees) + 90, Vector3.up);


        transform.rotation = radiansRotation;
    }
}

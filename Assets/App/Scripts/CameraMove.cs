using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
   [SerializeField] private float _sensivity = 2.0f;
   private Transform _cameraTransform;
   private float _xCameraRotation;

   private void Start()
   {
        

        _cameraTransform = Camera.main.transform;
        _cameraTransform.parent = transform;
        _cameraTransform.localPosition = Vector3.up * 0.75f;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
   }

   private void Update()
   {

    float x = Input.GetAxis("Mouse X");
    float y = Input.GetAxis("Mouse Y");

    _xCameraRotation -= _sensivity  * y;
    _xCameraRotation = Mathf.Clamp(_xCameraRotation, -90f , 90f);
    _cameraTransform.localRotation = Quaternion.Euler(_xCameraRotation , 0f,0f);

    transform.rotation *= Quaternion.Euler(0f, x * _sensivity, 0f) ;
   }
}

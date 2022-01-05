using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MouseLook : MonoBehaviour
{
    float mouseSensitivity = 300f ;
    public Transform playerBody;
    public Transform headTracker;
    float xRotation=0f;

    public Texture redTexture;
    public Transform raycastExitPiont;
    public GameObject middleCrosshair ;
    public GameObject leftCrosshair;
    public GameObject rightCrosshair;
    public GameObject topCrosshair;
    public GameObject bottomCrosshair;
    public GameObject crosshair;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
      float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
      playerBody.Rotate(Vector3.up*mouseX);
      float headRotationX = headTracker.position.y*10;

      xRotation -= mouseY;
      xRotation = Mathf.Clamp(xRotation,-90,90);
      transform.localRotation=Quaternion.Euler(xRotation + headRotationX,0f,0f);

      middleCrosshair.GetComponent<RawImage> ().texture = null;
      leftCrosshair.GetComponent<RawImage> ().texture   = null;
      rightCrosshair.GetComponent<RawImage> ().texture  = null;
      topCrosshair.GetComponent<RawImage> ().texture    = null;
      bottomCrosshair.GetComponent<RawImage> ().texture = null;

      RaycastHit hit;
      if(Physics.Raycast(raycastExitPiont.position,raycastExitPiont.forward,out hit,200))
        {
          if(hit.transform.name=="enemy"){
              middleCrosshair.GetComponent<RawImage> ().texture = redTexture;
              leftCrosshair.GetComponent<RawImage> ().texture   = redTexture;
              rightCrosshair.GetComponent<RawImage> ().texture  = redTexture;
              topCrosshair.GetComponent<RawImage> ().texture    = redTexture;
              bottomCrosshair.GetComponent<RawImage> ().texture = redTexture;
          }
          }
                  crosshair.GetComponent<Crosshair>().size= (hit.distance*2+55);
    }

}

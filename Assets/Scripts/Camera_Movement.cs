using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
  // This is expressed in "units per second".
  public float speedHorizontal = 2.0f;
  public float speedVertical = 2.0f;
  public float speed =1000f;
  public float pitch = 0.0f;

  private float yaw = 0.0f;

 //Camera WASD Movement
  void Update() {
    //Left movement
    if (Input.GetKey(KeyCode.A)) {
      transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
    }
    //Forward movement
    if (Input.GetKey(KeyCode.W)) {
      transform.position += transform.forward * speed * Time.deltaTime;
    }
    //Backward movement
    if (Input.GetKey(KeyCode.D)) {
      transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
    }
    //Right movement
     if (Input.GetKey(KeyCode.S)) {
      transform.position += transform.forward * -speed * Time.deltaTime;
    }
  
    //Camera Perspective movement
    yaw += speedHorizontal * Input.GetAxis("Mouse X"); //Left & Right
        pitch -= speedVertical * Input.GetAxis("Mouse Y"); //Up & Down

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
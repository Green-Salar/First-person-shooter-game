using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
      public Transform exitPoint;
      public AudioSource gunShot;
      public GameObject bullet;
      private float timeElapsed = 0;

      void Update()
      {

        if (Input.GetMouseButton(0)){
          GameObject tempBullet;
          if( timeElapsed > 100){

            tempBullet = Instantiate( bullet, exitPoint.position, exitPoint.rotation) as GameObject;

            //tempBullet.trasform.Rotate(vector3.left*90);

            tempBullet.GetComponent<Rigidbody>().velocity = transform.up*80;

            timeElapsed = 0;
            gunShot.Play();
            Destroy(tempBullet,2.0f);
          }

        }
            timeElapsed += Time.deltaTime * 1000;
      }

}

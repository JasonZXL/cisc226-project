using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adjust myTime variable can speed up or down shooting rate, approaching 0.5 is faster and vice versa;
public class weapon : MonoBehaviour
{
    public Transform shooting_postion;
    public GameObject bulletPrefab;
    public float fireDelta = 0.5f;

    private float nextFire = 0.5f;
    private GameObject newbulletPrefab;
    private float myTime = 0.4f;
    void Update(){
        myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            nextFire = myTime + fireDelta;
            newbulletPrefab = Instantiate(bulletPrefab,shooting_postion.position, shooting_postion.rotation) as GameObject;
            nextFire = nextFire - myTime;
            myTime = 0.4f;  
        }
    }

    
        
    
}

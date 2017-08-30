using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject projectile;
    public float offsetX = 0f;
    public float offsetY = 0f;
    public float visualCd;
    public float cd = 5f;
    public string key;
    float cdInt = 0;

	// Update is called once per frame
	void Update () {

        if(Input.GetButtonUp (key) && cdInt <= 0 )
        {
            cdInt = cd;

            Vector3 offset = transform.rotation * new Vector3(offsetX, offsetY, 0);
            Instantiate(projectile, transform.position + offset, transform.rotation);

        }
        cdInt -= Time.deltaTime;
        visualCd = cdInt;
	}
}

using UnityEngine;
using System.Collections;

public class BulletObject : MonoBehaviour {

    public float speed = 1;
  
    public float remain = 3;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        remain -= Time.deltaTime;


        transform.Translate(transform.forward * speed * Time.deltaTime);

        if(remain < 0)
        {
            remain = 3;
            gameObject.SetActive(false);
        }

	}
}

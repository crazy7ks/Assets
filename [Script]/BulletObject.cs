using UnityEngine;
using System.Collections;

public class BulletObject : MonoBehaviour {

    public float speed = 1;
  
    public float remain = 2;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        remain -= Time.deltaTime;
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, speed * Time.deltaTime))
        {
            Debug.Log(hit.collider.tag);
            if (hit.collider.tag == "Enemy")
            {
 
                UnActive();
                hit.collider.GetComponent<EnemyObject>().Damaged(1);
                //GameObject crashEffect = Instantiate(m_hitEffect, transform.position, transform.rotation) as GameObject;
                //if (m_iHP <= 0)
                //{
                //    GameObject deathEffect = Instantiate(m_deathEffect, transform.position, transform.rotation) as GameObject;
                //    Destroy(transform.gameObject);
                //}
            }
        }

        transform.Translate(transform.forward * speed * Time.deltaTime);

        if(remain < 0)
        {
            UnActive();
        }
	}   

    public void UnActive()
    {
        remain = 2;
        gameObject.SetActive(false);
    }
}

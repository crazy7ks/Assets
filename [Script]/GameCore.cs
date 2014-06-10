using UnityEngine;
using System.Collections;

public class GameCore : MonoBehaviour 
{


    //bullet manager 
    private const int MAX_BULLET = 20;
    private int curBullet = 0;
    private GameObject[] m_playerBullet = new GameObject[MAX_BULLET];
    public GameObject BulletPrefabs;
    
	void Start () 
    {
        for (int n = 0; n < MAX_BULLET; n++)
        {
            m_playerBullet[n] = Instantiate(BulletPrefabs) as GameObject;
            m_playerBullet[n].SetActive(false);
            m_playerBullet[n].transform.parent = gameObject.transform;
            Debug.Log(m_playerBullet[n]);
        }
	}

    public void requestBullet(Vector3 position, Vector3 dir,Vector3 scale)
    {
        m_playerBullet[curBullet].SetActive(true);
        m_playerBullet[curBullet].transform.position = position;
        m_playerBullet[curBullet].transform.rotation = Quaternion.LookRotation(dir);
        m_playerBullet[curBullet].transform.localScale = scale;

        curBullet++;
        if(curBullet == 20)
        {
            curBullet = 0;
        }
    }



}

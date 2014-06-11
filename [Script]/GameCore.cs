using UnityEngine;
using System.Collections;

public class GameCore : MonoBehaviour 
{
    //bullet manager 
    private const int MAX_BULLET = 20;
    private int curBullet = 0;
    private GameObject[] m_playerBullet = new GameObject[MAX_BULLET];
    public GameObject BulletPrefabs;
    public GameObject Hero;

    //EnemyManager Reference;
    private EnemyManager EM;

	void Start () 
    {
        //적군 관리자를 불러온다.
        EM = GameObject.Find("RespawnZone").GetComponent<EnemyManager>();

        Hero = GameObject.Find("Player");
        
        
        for (int n = 0; n < MAX_BULLET; n++)
        {
            m_playerBullet[n] = Instantiate(BulletPrefabs) as GameObject;
            m_playerBullet[n].SetActive(false);
            m_playerBullet[n].transform.parent = gameObject.transform;
            Debug.Log(m_playerBullet[n]);
        }
	}


    //총알 매니저 
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

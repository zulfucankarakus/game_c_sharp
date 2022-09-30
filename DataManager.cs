using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private int shoteBullet;
    public int totalShoteBullet;
    private int enemyKilled;
    public int totalEnemyKilled;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ShotBullet
    {
        get
        {
            return ShotBullet;
        }
        set
        {
            shoteBullet = value;
            GameObject.Find("ShotBulletText").GetComponent<Text>().text = "SHOT BULLET : " + ShotBullet.ToString();
        }
    }

    public int EnemyKilled
    {
        get
        {
            return enemyKilled;
        }
        set
        {
            enemyKilled = value;
            GameObject.Find("EnemyKilledText").GetComponent<Text>().text = "ENEMY KILLED : " + enemyKilled.ToString();
        }
    }

            
}

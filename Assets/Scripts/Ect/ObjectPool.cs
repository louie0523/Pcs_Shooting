using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private static ObjectPool instance = null;

    [SerializeField] GameObject playerBulletA_Prefab;
    [SerializeField] GameObject playerBulletB_Prefab;
    [SerializeField] GameObject guidedBullet_Prefab;
    [SerializeField] GameObject enemyBullet_Prefab;
    [SerializeField] GameObject bossBulletA_Prefab;
    [SerializeField] GameObject bossBulletB_Prefab;
    [SerializeField] GameObject enemyA_Prefab;
    [SerializeField] GameObject enemyB_Prefab;
    [SerializeField] GameObject enemyC_Prefab;
    [SerializeField] GameObject hpItem_Prefab;
    [SerializeField] GameObject powerItem_Prefab;
    [SerializeField] GameObject scoreItem_Prefab;

    [SerializeField] int playerBulletA_Count;
    [SerializeField] int playerBulletB_Count;
    [SerializeField] int guidedBullet_Count;
    [SerializeField] int enemyBullet_Count;
    [SerializeField] int bossBulletA_Count;
    [SerializeField] int bossBulletB_Count;
    [SerializeField] int enemyA_Count;
    [SerializeField] int enemyB_Count;
    [SerializeField] int enemyC_Count;
    [SerializeField] int hpItem_Count;
    [SerializeField] int powerItem_Count;
    [SerializeField] int scoreItem_Count;

    private Queue<GameObject> playerBulletAs = new Queue<GameObject>();
    private Queue<GameObject> playerBulletBs = new Queue<GameObject>();
    private Queue<GameObject> guidedBullets = new Queue<GameObject>();
    private Queue<GameObject> enemyBullets = new Queue<GameObject>();
    private Queue<GameObject> bossBulletAs = new Queue<GameObject>();
    private Queue<GameObject> bossBulletBs = new Queue<GameObject>();
    private Queue<GameObject> enemyAs = new Queue<GameObject>();
    private Queue<GameObject> enemyBs = new Queue<GameObject>();
    private Queue<GameObject> enemyCs = new Queue<GameObject>();
    private Queue<GameObject> hpItems = new Queue<GameObject>();
    private Queue<GameObject> powerItems = new Queue<GameObject>();
    private Queue<GameObject> scoreItems = new Queue<GameObject>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        Initialize();
    }
    private void Initialize()
    {
        for(int i = 0; i < playerBulletA_Count; i++)
        {
            GameObject obj = Instantiate(playerBulletA_Prefab);
            obj.SetActive(false);
            playerBulletAs.Enqueue(obj);
        }
        for (int i = 0; i < playerBulletB_Count; i++)
        {
            GameObject obj = Instantiate(playerBulletB_Prefab);
            obj.SetActive(false);
            playerBulletBs.Enqueue(obj);
        }
        for (int i = 0; i < guidedBullet_Count; i++)
        {
            GameObject obj = Instantiate(guidedBullet_Prefab);
            obj.SetActive(false);
            guidedBullets.Enqueue(obj);
        }
        for (int i = 0; i < enemyBullet_Count; i++)
        {
            GameObject obj = Instantiate(enemyBullet_Prefab);
            obj.SetActive(false);
            enemyBullets.Enqueue(obj);
        }
        for (int i = 0; i < bossBulletA_Count; i++)
        {
            GameObject obj = Instantiate(bossBulletA_Prefab);
            obj.SetActive(false);
            bossBulletAs.Enqueue(obj);
        }
        for (int i = 0; i < bossBulletB_Count; i++)
        {
            GameObject obj = Instantiate(bossBulletB_Prefab);
            obj.SetActive(false);
            bossBulletBs.Enqueue(obj);
        }
        for (int i = 0; i < enemyA_Count; i++)
        {
            GameObject obj = Instantiate(enemyA_Prefab);
            obj.SetActive(false);
            enemyAs.Enqueue(obj);
            Debug.Log(enemyAs.Count);
        }
        for (int i = 0; i < enemyB_Count; i++)
        {
            GameObject obj = Instantiate(enemyB_Prefab);
            obj.SetActive(false);
            enemyBs.Enqueue(obj);
        }
        for (int i = 0; i < enemyC_Count; i++)
        {
            GameObject obj = Instantiate(enemyC_Prefab);
            obj.SetActive(false);
            enemyCs.Enqueue(obj);
        }
        for (int i = 0; i < hpItem_Count; i++)
        {
            GameObject obj = Instantiate(hpItem_Prefab);
            obj.SetActive(false);
            hpItems.Enqueue(obj);
        }
        for (int i = 0; i < powerItem_Count; i++)
        {
            GameObject obj = Instantiate(powerItem_Prefab);
            obj.SetActive(false);
            powerItems.Enqueue(obj);
        }
        for (int i = 0; i < scoreItem_Count; i++)
        {
            GameObject obj = Instantiate(scoreItem_Prefab);
            obj.SetActive(false);
            scoreItems.Enqueue(obj);
        }
    }
    public GameObject GetObject(ObjectType type)
    {
        GameObject obj = null;
        switch (type)
        {
            case ObjectType.PlayerBulletA:
                obj = playerBulletAs.Dequeue(); 
                break;
            case ObjectType.PlayerBulletB:
                obj = playerBulletBs.Dequeue();
                break;
            case ObjectType.GuidedBullet:
                obj = guidedBullets.Dequeue();
                break;
            case ObjectType.EnemyBullet:
                obj = enemyBullets.Dequeue();
                break;
            case ObjectType.BossBulletA:
                obj = bossBulletAs.Dequeue();
                break;
            case ObjectType.BossBulletB:
                obj = bossBulletBs.Dequeue();
                break;
            case ObjectType.EnemyA:
                obj = enemyAs.Dequeue();
                break;
            case ObjectType.EnemyB:
                obj = enemyBs.Dequeue();
                break;
            case ObjectType.EnemyC:
                obj = enemyCs.Dequeue();
                break;
            case ObjectType.HpItem:
                obj = hpItems.Dequeue();
                break;
            case ObjectType.PowerItem:
                obj = powerItems.Dequeue();
                break;
            case ObjectType.ScoreItem:
                obj = scoreItems.Dequeue();
                break;
        }
        obj.SetActive(true);
        return obj;
    }
    public void DestroyObject(GameObject obj, ObjectType type)
    {
        obj.SetActive(false);
        switch (type)
        {
            case ObjectType.PlayerBulletA:
                playerBulletAs.Enqueue(obj);
                break;
            case ObjectType.PlayerBulletB:
                playerBulletBs.Enqueue(obj);
                break;
            case ObjectType.GuidedBullet:
                guidedBullets.Enqueue(obj);
                break;
            case ObjectType.EnemyBullet:
                enemyBullets.Enqueue(obj);
                break;
            case ObjectType.BossBulletA:
                bossBulletAs.Enqueue(obj);
                break;
            case ObjectType.BossBulletB:
                bossBulletBs.Enqueue(obj);
                break;
            case ObjectType.EnemyA:
                enemyAs.Enqueue(obj);
                break;
            case ObjectType.EnemyB:
                enemyBs.Enqueue(obj);
                break;
            case ObjectType.EnemyC:
                enemyCs.Enqueue(obj);
                break;
            case ObjectType.HpItem:
                hpItems.Enqueue(obj);
                break;
            case ObjectType.PowerItem:
                powerItems.Enqueue(obj);
                break;
            case ObjectType.ScoreItem:
                scoreItems.Enqueue(obj);
                break;
        }
    }

    public static ObjectPool Instance
    {
        get
        {
            if(instance == null)
            {
                return null;
            }
            return instance;
        }
    }
}
public enum ObjectType
{
    PlayerBulletA, PlayerBulletB, GuidedBullet, EnemyBullet, EnemyA, EnemyB, EnemyC, HpItem, PowerItem, ScoreItem, BossBulletA, BossBulletB, 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "PlayerBullet":
            case "EnemyBullet":
                ObjectPool.Instance.DestroyObject(collision.gameObject, collision.GetComponent<Bullet>().bulletType);
                break;
            case "Item":
                ObjectPool.Instance.DestroyObject(collision.gameObject, collision.GetComponent<Item>().itemType);
                break;
        }
    }
}

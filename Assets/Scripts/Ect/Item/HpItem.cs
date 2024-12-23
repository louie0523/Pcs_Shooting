using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : Item
{
    public override void GiveEffect()
    {
        if(GameManager.Instance.player.hp <3)
        {
            GameManager.Instance.player.hp++;
            ObjectPool.Instance.DestroyObject(this.gameObject, itemType);
        }
        ObjectPool.Instance.DestroyObject(this.gameObject, itemType);
    }
}

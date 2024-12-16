using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ObjectType itemType;
    public virtual void GiveEffect()
    {
        Debug.Log("GiveEffect");
    }
}

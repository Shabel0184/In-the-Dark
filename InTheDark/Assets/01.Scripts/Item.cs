using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item",menuName = "New Item/item")]
public class Item : ScriptableObject // 게임 오브젝트에 붙일 필요 x
{
    public enum ItemType // 아이템 유형
    {
        Equipment,
        normal,
        Special,
    }

    public string itemName; // 아이템 이름
    public ItemType itemType; // 아이템 유형
    public Sprite itemImage; //아이템의 이미지 (퀵슬롯 안에 띄움)
    public GameObject itemPrefab; // 아이템의 프리팹


}

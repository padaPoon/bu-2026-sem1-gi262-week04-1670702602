using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPExit : Identity
    {
        public GameObject YouWin;
        public string ItemToOpen = "Key"; // กำหนดชื่อไอเท็มที่ต้องการใช้ในการเปิดทางออก
        public int ItemAmountToOpen = 2; // กำหนดจำนวนไอเท็มที่ต้องการใช้ในการเปิดทางออก
        // กำหนดชื่อไอเท็มและจำนวนที่ต้องการใช้ในการเปิดทางออก

        public override bool Hit()
        {
            // ตรวจสอบว่าผู้เล่นมีไอเท็มที่ต้องการหรือไม่
            bool isHasItemAmount = mapGenerator.player.inventory.HasItem(ItemToOpen, ItemAmountToOpen);
            if (isHasItemAmount)
            {
                YouWin.SetActive(true);
                Debug.Log("You win");
                return true;
            }
            else
            {
                Debug.Log("Need " + ItemAmountToOpen + " " + ItemToOpen + " to open the exit.");
                return false;
            }
        }
    }
}
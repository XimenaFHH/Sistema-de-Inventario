using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory.UI
{
    public class UIInventoryDescription : MonoBehaviour
    {
        [SerializeField]
        private Image itemImage;
        [SerializeField]
        private TMP_Text title;
        [SerializeField]
        private TMP_Text description;


        public void Awake()
        {
            ResetDescription();
        }

        public void ResetDescription()
        {
            this.itemImage.gameObject.SetActive(false);
            this.title.text = "";
            this.description.text = "";
        }

        public void SetDescription(Sprite sprite, string itemName,
            string itemDescription)
        {
            this.itemImage.gameObject.SetActive(true);
            this.itemImage.sprite = sprite;
            this.title.text = itemName;
            this.description.text = itemDescription;
        }
    }
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;
//using System;
//using UnityEngine.EventSystems;

//public class UIInventoryDescription : MonoBehaviour
//{
//    public Image itemImage;
//    public TMP_Text title;
//    public TMP_Text description;

//    public void Awake()
//    {
//        ResetDescription();
//    }

//    public void ResetDescription()
//    {
//        this.itemImage.gameObject.SetActive(false);
//        this.title.text = "";
//        this.description.text = "";
//    }

//    public void SetDescription(Sprite sprite, string itemName, string itemDescription)
//    {
//        this.itemImage.gameObject.SetActive(true);
//        this.itemImage.sprite = sprite;
//        this.title.text = itemName;
//        this.description.text = itemDescription;
//    }

//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public int selectedItem;
    public Inventory inventory;
    public GameObject itemPrefab;
    void Start()
    {
        selectedItem = -1;
        DisplayInventory();
    }

    public void DisplayInventory(){
        foreach(Item i in inventory.items){
            GameObject o = Instantiate(itemPrefab, this.gameObject.transform);
            o.name = "0";
            o.transform.GetChild(0).GetComponent<Image>().sprite = i.icon;
            o.GetComponent<Button>().onClick.AddListener(delegate {setSelected(o.gameObject);});
        }
    }

    public void AddItemToInventoryDisplay(){
        GameObject o = Instantiate(itemPrefab, this.gameObject.transform);
            o.name = "0";
            o.transform.GetChild(0).GetComponent<Image>().sprite = inventory.items.Last.Value.icon;
            o.GetComponent<Button>().onClick.AddListener(delegate {setSelected(o.gameObject);});
    }

    public void RemoveItemFromInventoryDisplay(){

    }

    public void setSelected(GameObject obj){
        if (selectedItem != -1){
            gameObject.transform.GetChild(selectedItem).GetComponent<Outline>().enabled = false;
            if (selectedItem == obj.transform.GetSiblingIndex()){
                selectedItem = -1;
                return;
            }
        }
        selectedItem = obj.transform.GetSiblingIndex();
        obj.GetComponent<Outline>().enabled = true;
    }
}

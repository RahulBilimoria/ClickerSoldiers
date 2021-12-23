using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBar : MonoBehaviour
{
    public GameObject[] menus;
    private int activeIndex;

    void Start()
    {
        activeIndex = -1;
    }

    public void showMenu(int index){
        if (activeIndex != -1){
            menus[activeIndex].SetActive(!menus[activeIndex].activeInHierarchy);
            if (activeIndex == index) {
                activeIndex = -1;
                return;
            }
        }
        menus[index].SetActive(!menus[index].activeInHierarchy);
        activeIndex = index;
    }
}
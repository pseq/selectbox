using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour {

    private bool selected;
    public Material selectedMaterial;
    public Material unselectedMaterial;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetSelected()
    {
        // При выборе юнита - обозначаем его как выделенный.
        selected = true;
        selectMarker.enabled = true;

        // Добавляем в массив выбранных
        gameControl.GetComponent<GameControl>().AddSelected(gameObject);
    }

    public void UnsetSelected()
    {
        // При отмене выбора юнита - снимаем выделение.
        selected = false;
        selectMarker.enabled = false;

        // Удаляем из массива выбранных
        gameControl.GetComponent<GameControl>().DeleteSelected(gameObject);
    }
}

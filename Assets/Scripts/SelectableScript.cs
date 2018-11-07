using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableScript : MonoBehaviour {

    private bool selected;
    public Material Mat;
    private Color Defaultcolor;

    // Use this for initialization
    void Start () {
        Mat = GetComponent<Renderer>().material;
        Defaultcolor = Mat.color;
        //selectMarker = transform.Find("SelectMarker").GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetSelected()
    {
        // При выборе юнита - обозначаем его как выделенный.
        selected = true;
        Mat.color = Color.red;
        //selectMarker.enabled = true;

        // Добавляем в массив выбранных
        //gameControl.GetComponent<GameControl>().AddSelected(gameObject);
    }

    public void UnsetSelected()
    {
        // При отмене выбора юнита - снимаем выделение.
        selected = false;
        Mat.color = Defaultcolor;

        // Удаляем из массива выбранных
        //gameControl.GetComponent<GameControl>().DeleteSelected(gameObject);
    }
}

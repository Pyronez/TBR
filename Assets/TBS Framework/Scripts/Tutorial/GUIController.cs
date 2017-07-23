using UnityEngine;

public class GUIController : MonoBehaviour
{
    public CellGrid CellGrid;

	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            CellGrid.EndTurn();//User ends his turn by pressing "n" on keyboard.
        }
	}
}

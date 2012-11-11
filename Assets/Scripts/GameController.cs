using UnityEngine;
using System.Collections;

public class GameController : MonoSingleton<GameController> {

 
    public GameObject tile;
 
    protected override void Init ()
    {
        GameInit ();
    }
    
    public void GameInit ()
    {
        GridCamera.RaycastOn ();
        GridGenerator.instance.Clear ();
        GridGenerator.instance.GenerateHex (tile, Vector3.zero, 10, 10);
    }
        
    public void Update ()
    {
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    private PlayerController playerController = null;
    private TerrainManager terrainManager = null;

    void Start() {
        playerController = gameObject.GetComponent<PlayerController>();   
        terrainManager = gameObject.GetComponent<TerrainManager>();         
    }

    void Update() {
        playerController.checkKeyPress();
        terrainManager.updateTerrainType();
    }
}

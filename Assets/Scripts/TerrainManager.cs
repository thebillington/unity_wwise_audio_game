using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour {

    private AudioController audioController = null;

    public Texture2D terrainTexture;
    private string currentColour = "";

    Dictionary<string, string> colourSwitch = new Dictionary<string, string>() {
        {"r0g202b32", "Forest"},
        {"r144g144b144", "Rocky"},
        {"r206g255b46", "Sand"},
        {"r0g79b13", "Swamp"}
    };

    void Start() {
        audioController = gameObject.GetComponent<AudioController>(); 
    }

    public void updateTerrainType() {
        Color c = getPixelAtCoordinate(transform.position.x, transform.position.y);
        string colourString = "r" + (int)(c.r*255) + "g" + (int)(c.g*255) + "b" + (int)(c.b*255);
        
        if (colourString != currentColour) {
            currentColour = colourString;
            foreach (var key in colourSwitch.Keys)
            {
                if (key == currentColour) {
                    print(colourSwitch[currentColour]);
                }
            }
        }
    }

    private Color getPixelAtCoordinate(float x, float y) {
        int newX = (int)(x * 100) + 960;
        int newY = (int)(y * 100) + 540;
        return terrainTexture.GetPixel(newX,newY);
    }
}

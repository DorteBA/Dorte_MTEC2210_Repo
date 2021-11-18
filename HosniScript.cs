using UnityEngine;

public class Hosniscript : MonoBehaviour
{
    public GameObject teacher;
    private SpriteRenderer beardSprite;
    private SpriteRenderer hairSprite;
    private SpriteRenderer faceSprite;

void Start()
{
    teacher = GameObject.Find("Hosni")
    //beard = teacher.transform.GetChild(0).gameobject
    hairSprite = teacher.transform.GetChild(1).gameobject.GetComponent<SpriteRenderer>();
    faceSprite = teacher.transform.GetChild(2).gameobject.GetComponent<SpriteRenderer>();
    beardSprite = teacher.transform.GetChild(0).gameobject.GetComponent<SpriteRenderer>();
}
private void Update()
{
    //Debug.Log(hairSprite.color);
    //hairSprite.color = new Color(50, 150, 100, 50);
}
public void ColorChange()
{
    hairSprite.color = new Color(70, 150, 100, 255);
    beardSprite.color = new Color(0, 150, 0, 255);
    faceSprite.color = new Color(0, 0, 150, 255);
}

}


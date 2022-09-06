using TMPro;
using UnityEngine;

public class yazi : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI pointtext;
     int score = 0;

    // Update is called once per frame
    void Update()
    { 

        //    pointtext.text = player.position.z.ToString("0");// burda referans olarak veremedim pointtextt e text veremedim.
    }

    public void Updatetext()
    {
        pointtext.text = score.ToString();
        
    }

    public void Addpoint(int point)
    {

        score = point + score;
        Updatetext();
        
    }
}

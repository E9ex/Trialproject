
using UnityEngine;
using UnityEngine.UI;

public class yazi : MonoBehaviour
{
    public Transform player;
    public Text pointtext;

    // Update is called once per frame
    void Update()
    {
        pointtext.text = player.position.z.ToString("0");// burda referans olarak veremedim pointtextt e text veremedim.
    }

   
    
}

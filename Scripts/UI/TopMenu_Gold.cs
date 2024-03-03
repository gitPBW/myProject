using UnityEngine;
using TMPro;

public class TopMenu_Gold : MonoBehaviour
{
    public TMP_Text tmptext;
    public DataResource dataResource;//юс╫ц╥н
    int nCount;

    private void Start()
    {
        dataResource = GetComponent<DataResource>();
        nCount = dataResource.Item.nGold;
        tmptext.text = nCount.ToString();
    }

    private void Update()
    {
        if(nCount != dataResource.Item.nGold)
        {
            nCount = dataResource.Item.nGold;
            ChangeCount(nCount);
        }

    }

    void ChangeCount(int num)
    {
        if(num >= 1000 && num < 1000000)
        {
            tmptext.text = (num / 1000).ToString() + "K";
        }
        else
        {
            tmptext.text = num.ToString();
        }
    }
}

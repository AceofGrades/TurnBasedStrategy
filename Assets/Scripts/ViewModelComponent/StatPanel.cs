using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StatPanel : MonoBehaviour
{
    public Panel panel;
    public Sprite allyBackground;
    public Sprite enemyBackground;
    public Image background;
    public Image avatar;
    public Text nameLabel;
    public Text hpLabel;
    public Text apLabel;
    public Text lvLabel;
    public void Display(GameObject obj)
    {
        // Temp until I add a component to determine unit alliances
        background.sprite = UnityEngine.Random.value > 0.5f ? enemyBackground : allyBackground;
        // avatar.sprite = null; Need a component which provides this data
        nameLabel.text = obj.name;
        Stats stats = obj.GetComponent<Stats>();
        if (stats)
        {
            hpLabel.text = string.Format("HP {0} / {1}", stats[StatTypes.HP], stats[StatTypes.MHP]);
            apLabel.text = string.Format("MP {0} / {1}", stats[StatTypes.AP], stats[StatTypes.MAP]);
            lvLabel.text = string.Format("LV. {0}", stats[StatTypes.LVL]);
        }
    }
}

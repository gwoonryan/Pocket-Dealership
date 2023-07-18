using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageDropdownScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var countries = new List<string> {"Afrikaans","Albanian","Arabic","Armenian","Basque","Bengali","Bulgarian","Catalan","Cambodian",
            "Chinese (Mandarin)","Croatian","Czech","Danish","Dutch","English","Estonian","Fiji","Finnish","French","Georgian","German",
            "Greek","Gujarati","Hebrew","Hindi","Hungarian","Icelandic","Indonesian","Irish","Italian","Japanese","Javanese","Korean",
            "Latin","Latvian","Lithuanian","Macedonian","Malay","Malayalam","Maltese","Maori","Marathi","Mongolian","Nepali","Norwegian",
            "Persian","Polish","Portuguese","Punjabi","Quechua","Romanian","Russian","Samoan","Serbian","Slovak","Slovenian","Spanish",
            "Swahili","Swedish","Tamil","Tatar","Telugu","Thai","Tibetan","Tonga","Turkish","Ukrainian","Urdu","Uzbek","Vietnamese","Welsh","Xhosa"};
        var datas = new List<TMP_Dropdown.OptionData>();
        foreach (string str in countries)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData(str);
            datas.Add(data);
        }
        gameObject.GetComponent<TMP_Dropdown>().AddOptions(datas);
    }
}

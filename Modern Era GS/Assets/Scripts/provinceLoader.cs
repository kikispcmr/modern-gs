using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml; //Needed for XML functionality
using System.Xml.Serialization; //Needed for XML Functionality
using System.IO;
using System.Xml.Linq; //Needed for XDocument

public class provinceLoader : MonoBehaviour
{
    public struct provinces
    {
        public provinces(int provID, string name)
        {
            ProvID = provID;
            Name = name;
        }
        public int ProvID { get; }
        public string Name { get; }

        public override string ToString() => $"({ProvID},{Name})";
    }



    public Dictionary<Color, provinces> provincesDic = new Dictionary<Color, provinces>();

    void Start()
    {
        xmlReader();

    }

    void xmlReader()
    {
        TextAsset txtXmlAsset = Resources.Load<TextAsset>("Provinces");
        var doc = XDocument.Parse(txtXmlAsset.text);

        var allDict = doc.Element("provinces").Elements("province");

        foreach (var oneDict in allDict)
        {
            var provinceName = oneDict.Element("name");
            var provinceColor = oneDict.Element("rgb");
            var provinceID = oneDict.Element("provID");

            string provName = provinceName.ToString().Replace("<name>", "").Replace("</name>", "");
            string provColor = provinceColor.ToString().Replace("<rgb>", "").Replace("</rgb>", "");
            int provID = int.Parse(provinceID.ToString().Replace("<provID>", "").Replace("</provID>", ""));

            provinces currentProvince = new provinces(provID, provName);
            
            provincesDic.Add(calculateColor(provColor), currentProvince);



            Debug.Log("For loop succesfully ran");
            Debug.Log("Province at " + provincesDic[new Color(112/255,255/255,99/255)]);
        }
        Debug.Log("Succesfully ran");
    }

    Color calculateColor(string pseudoColor)
    {
        string[] rgb = pseudoColor.Split(',');
        Color actualColor = new Color(float.Parse(rgb[0])/255, float.Parse(rgb[1])/255, float.Parse(rgb[2])/255);
        return actualColor;
    }

}

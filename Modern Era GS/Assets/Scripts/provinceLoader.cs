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



    public Dictionary<string, provinces> provincesDic = new Dictionary<string, provinces>();

    void Start()
    {
        int i;
        TextAsset txtXmlAsset = Resources.Load<TextAsset>("provinces");
        var doc = XDocument.Parse(txtXmlAsset.text);

        var allDict = doc.Element("provinces").Elements("provID");
        foreach(var oneDict in allDict)
        {
            var provinceName = oneDict.Elements("name");
            var provinceColor = oneDict.Elements("rgb");
            var provID = oneDict.Elements("provID");

            string first = provinceName.ToString();
            string second = provinceColor.ToString();
            int third = int.Parse(provID.ToString());

            provincesDic.Add(first, new provinces(third, second));
            Debug.Log("Succesfully ran");
            Debug.Log("Province at " + provincesDic["112,255,99"]);
        }
    }

}

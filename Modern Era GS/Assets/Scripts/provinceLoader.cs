using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml; //Needed for XML functionality
using System.Xml.Serialization; //Needed for XML Functionality
using System.IO;
using System.Xml.Linq; //Needed for XDocument

public class provinceLoader : MonoBehaviour
{
    XDocument XMLprovinces;

    IEnumerable<XElement> items;

    int iteration = 0;

    public struct provinces
    {
        public provinces(int provID, string name)
        {
            ProvID = provID;
            Name = name;
        }
        public int ProvID { get;}
        public string Name { get; }

        public override string ToString() => $"({ProvID},{Name})";
    }

    

      Dictionary<Color, provinces> provincesDic = new Dictionary<Color, provinces>();

// Start is called before the first frame update
void Start()
    {
         LoadXML();
    }

void LoadXML()
{
    XMLprovinces = XDocument.Load("Assets/XML Files/Provinces.xml");
    items = XMLprovinces.Descendants("").Elements();

    foreach (var item in items)
    {
        if (item.Parent.Attribute("provID").Value == iteration.ToString())
        {
            provID = int.Parse(item.Parent.Attribute(“number”).Value);
            name = item.Parent.Element(“name”).Value.Trim(); 
            rgb = item.Parent.Element(“rgb”).Value.Trim();

            /*Create a new Index in the List, which will be a new XMLData object and pass the previously assigned variables as arguments so they get assigned to the new object’s variables.*/

            
        }
        data.Add(new XMLData(provID, name, rgb));


        /*To test and make sure the data has been applied to properly, print out the musicClip name from the data list’s current index. This will let us know if the objects in the list have been created successfully and if their variables have been assigned the right values.*/

        

        Debug.Log(data[iteration].dialogueText); 

        iteration++; //increment the iteration by 1
    }
}

}

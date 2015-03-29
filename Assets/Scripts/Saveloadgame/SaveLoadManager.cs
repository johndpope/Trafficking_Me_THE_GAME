using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;
using System.Text;
using System;

public class SaveLoadManager : MonoBehaviour
{

	// Use this for initialization
    private string filedata = "Assets/SaveData/savedata.txt";
    private int choice;
    private XmlElement[] xmlrawData = new XmlElement[4];
    public string[] position = new string[4];
    public XmlDocument xml = new XmlDocument();
    public string[] topicdate;
    private GameController system;
    private CharacterEmotion emotion;
    private PhoneManage phone;
	void Start () {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
            emotion = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
            phone = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>().phone;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void loaddataforsave()
    {
        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(filedata);

            for (int a = 0; a < xmlrawData.Length; a++)
            {
                XmlNodeList dataList = xmlDoc.GetElementsByTagName("profile" + a);
                if (dataList != null)
                {
                    foreach (XmlNode dataInfo in dataList)
                    {
                        XmlNodeList dataContent = dataInfo.ChildNodes;
                        xmlrawData[a] = xml.CreateElement("profile" + a);
                        foreach (XmlNode dataItems in dataContent)
                        {
                            XmlElement profileInnerElement;
                            if (dataItems.Name == "time")
                            {
                                profileInnerElement = xml.CreateElement("time");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "score")
                            {
                                profileInnerElement = xml.CreateElement("score");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "Questtype")
                            {
                                profileInnerElement = xml.CreateElement("Questtype");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "QuestID")
                            {
                                profileInnerElement = xml.CreateElement("QuestID");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "questItem")
                            {
                                XmlElement profileInnerElementroot = xml.CreateElement("questItem");
                                XmlNodeList dataContentInventory = dataItems.ChildNodes;
                                foreach (XmlNode dataItemInventory in dataContentInventory)
                                {
                                    profileInnerElement = xml.CreateElement("item");
                                    profileInnerElement.SetAttribute("ID", dataItemInventory.Attributes["ID"].Value);
                                    profileInnerElementroot.AppendChild(profileInnerElement);
                                }
                                xmlrawData[a].AppendChild(profileInnerElementroot);
                            }
                            if (dataItems.Name == "courage")
                            {
                                profileInnerElement = xml.CreateElement("courage");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "bravery")
                            {
                                profileInnerElement = xml.CreateElement("bravery");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "trustness")
                            {
                                profileInnerElement = xml.CreateElement("trustness");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "previous_map")
                            {
                                profileInnerElement = xml.CreateElement("previous_map");
                                profileInnerElement.InnerText = dataItems.InnerText;
                                xmlrawData[a].AppendChild(profileInnerElement);
                            }
                            if (dataItems.Name == "victimList")
                            {
                                XmlElement profileInnerElementroot = xml.CreateElement("victimList");
                                XmlNodeList dataContentInventory = dataItems.ChildNodes;
                                foreach (XmlNode dataItemInventory in dataContentInventory)
                                {
                                    profileInnerElement = xml.CreateElement("victim");
                                    profileInnerElement.SetAttribute("ID", dataItemInventory.Attributes["ID"].Value);
                                    profileInnerElementroot.AppendChild(profileInnerElement);
                                }
                                xmlrawData[a].AppendChild(profileInnerElementroot);
                            }
                            if (dataItems.Name == "doc")
                            {
                                XmlElement profileInnerElementroot = xml.CreateElement("doc");
                                XmlNodeList dataContentInventory = dataItems.ChildNodes;
                                foreach (XmlNode dataItemInventory in dataContentInventory)
                                {
                                    profileInnerElement = xml.CreateElement("document");
                                    profileInnerElement.SetAttribute("ID", dataItemInventory.Attributes["ID"].Value);
                                    profileInnerElementroot.AppendChild(profileInnerElement);
                                }
                                xmlrawData[a].AppendChild(profileInnerElementroot);
                            }
                            if (dataItems.Name == "haveConveration")
                            {
                                XmlElement profileInnerElementroot = xml.CreateElement("haveConveration");
                                XmlNodeList dataContentInventory = dataItems.ChildNodes;
                                foreach (XmlNode dataItemInventory in dataContentInventory)
                                {
                                    profileInnerElement = xml.CreateElement("Con");
                                    profileInnerElement.SetAttribute("MapID", dataItemInventory.Attributes["MapID"].Value);
                                    profileInnerElement.SetAttribute("haveCon", dataItemInventory.Attributes["haveCon"].Value);
                                    profileInnerElementroot.AppendChild(profileInnerElement);
                                }
                                xmlrawData[a].AppendChild(profileInnerElementroot);
                            }
                            if (dataItems.Name == "smartSystem")
                            {
                                XmlElement profileInnerElementroot = xml.CreateElement("smartSystem");
                                XmlNodeList dataContentInventory = dataItems.ChildNodes;
                                foreach (XmlNode dataItemInventory in dataContentInventory)
                                {
                                    profileInnerElement = xml.CreateElement("smart");
                                    profileInnerElement.SetAttribute("MapID", dataItemInventory.Attributes["MapID"].Value);
                                    profileInnerElement.SetAttribute("value", dataItemInventory.Attributes["value"].Value);
                                    profileInnerElementroot.AppendChild(profileInnerElement);
                                }
                                xmlrawData[a].AppendChild(profileInnerElementroot);
                            }
                        }
                    }
                }
            }
        }
        catch
        {

        }
    }
    public void BuildData()
    {
        XmlElement rootElement = xml.CreateElement("player");
        xml.AppendChild(rootElement);
        // Create the player profile child element
        XmlElement profileElement = xml.CreateElement("profile" + choice);
        // Add the profileElement to the rootElement
        rootElement.AppendChild(profileElement);
        XmlElement profileInnerElement;

        profileInnerElement = xml.CreateElement("time");
        DateTime saveUtcNow = DateTime.UtcNow;
        profileInnerElement.InnerText = saveUtcNow.ToString();
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("score");
        profileInnerElement.InnerText = system.getScore()+"";
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("Questtype");
        Quest temp = system.getCurrentQuest();
        if (temp.GetType() == typeof(FindingQuest))
        {
            profileInnerElement.InnerText = "Finding";
            profileElement.AppendChild(profileInnerElement);

            profileInnerElement = xml.CreateElement("questItem");
            FindingQuest raw = (FindingQuest)temp;
            int[] itemID = raw.getALLItemList(); ;
            for (int i = 0; i < itemID.Length; i++)
            {
                XmlElement elementItem = xml.CreateElement("document");
                elementItem.SetAttribute("ID", itemID[i] + "");
                profileInnerElement.AppendChild(elementItem);
            }
            profileElement.AppendChild(profileInnerElement);

        }
        else if (temp.GetType() == typeof(MapQuest))
        {
            profileInnerElement.InnerText = "Map";
            profileElement.AppendChild(profileInnerElement);
        }
        else if (temp.GetType() == typeof(BossQuest))
        {
            profileInnerElement.InnerText = "Boss";
            profileElement.AppendChild(profileInnerElement);
        }

        profileInnerElement = xml.CreateElement("courage");
        profileInnerElement.InnerText = emotion.characterDetail.getEncouragementStat() + "";
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("bravery");
        profileInnerElement.InnerText = emotion.characterDetail.getBraveryStat() + "";
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("trustness");
        profileInnerElement.InnerText = emotion.characterDetail.getTrustnessStat() + "";
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("previous_map");
        profileInnerElement.InnerText = system.previousMap + "";
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("victimList");
        int[] victims = system.getALLvictimList();
        for (int i = 0; i < victims.Length; i++)
        {
            XmlElement elementItem = xml.CreateElement("victim");
            elementItem.SetAttribute("ID", victims[i]+"");
            profileInnerElement.AppendChild(elementItem);
        }
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("doc");
        int[] doc = phone.docManager.getALLDocCollect();
        for (int i = 0; i < doc.Length; i++)
        {
            XmlElement elementItem = xml.CreateElement("document");
            elementItem.SetAttribute("ID", doc[i] + "");
            profileInnerElement.AppendChild(elementItem);
        }
        profileElement.AppendChild(profileInnerElement);


        profileInnerElement = xml.CreateElement("haveConveration");
        int[] mapIDQuest;
        bool[] haveConQuest;
        temp.getAllConversationMapID(out mapIDQuest,out haveConQuest);
        for (int i = 0; i < mapIDQuest.Length; i++)
        {
            XmlElement elementItem = xml.CreateElement("Con");
            elementItem.SetAttribute("MapID", mapIDQuest[i] + "");
            elementItem.SetAttribute("haveCon", haveConQuest[i] + "");
            profileInnerElement.AppendChild(elementItem);
        }
        profileElement.AppendChild(profileInnerElement);

        profileInnerElement = xml.CreateElement("smartSystem");
        string[] mapIDSmart;
        int[] valueSmart;
        system.getALLsmartsystemvalue(out mapIDSmart, out valueSmart);
        for (int i = 0; i < mapIDQuest.Length; i++)
        {
            XmlElement elementItem = xml.CreateElement("smart");
            elementItem.SetAttribute("MapID", mapIDSmart[i] + "");
            elementItem.SetAttribute("value", valueSmart[i] + "");
            profileInnerElement.AppendChild(elementItem);
        }
        profileElement.AppendChild(profileInnerElement);

        for (int i = 0; i < xmlrawData.Length; i++)
        {
            if (i != choice && xmlrawData[i] != null)
            {
                rootElement.AppendChild(xmlrawData[i]);
            }
        }
        string data = xml.OuterXml;
        //System.IO.File.WriteAllText(filedata, data);
        PlayerPrefs.SetString("save", data);
        PlayerPrefs.Save();
        xml.RemoveAll();
    }
    public void LoadData(int t)
    {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        emotion = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
        phone = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>().phone;
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(PlayerPrefs.GetString("save"));
        XmlNodeList dataList = xmlDoc.GetElementsByTagName("profile" + t);
        string questType = "";
        foreach (XmlNode dataInfo in dataList)
        {
            XmlNodeList dataContent = dataInfo.ChildNodes;
            foreach (XmlNode dataItems in dataContent)
            {
                
                if (dataItems.Name == "score")
                {
                    system.setScore(int.Parse(dataItems.InnerText));
                }
                if (dataItems.Name == "Questtype")
                {
                    questType = dataItems.InnerText;
                }
                if (dataItems.Name == "QuestID")
                {
                    system.changeCurrentMission(int.Parse(dataItems.InnerText));
                }
                if (dataItems.Name == "questItem")
                {
                    FindingQuest raw = (FindingQuest)(system.getCurrentQuest());
                    XmlNodeList dataContentInventory = dataItems.ChildNodes;
                    foreach (XmlNode dataItemInventory in dataContentInventory)
                    {
                        raw.setAllCurrentItemisCollect(int.Parse(dataItemInventory.Attributes["ID"].Value));
                    }
                    system.setCurrentMission(raw);
                }
                if (dataItems.Name == "courage")
                {
                    emotion.characterDetail.setEncouragementStat(int.Parse(dataItems.InnerText));
                }
                if (dataItems.Name == "bravery")
                {
                    emotion.characterDetail.setBraveryStat(int.Parse(dataItems.InnerText));
                }
                if (dataItems.Name == "trustness")
                {
                    emotion.characterDetail.setTrustnessStat(int.Parse(dataItems.InnerText));
                }
                if (dataItems.Name == "previous_map")
                {
                    system.previousMap = dataItems.InnerText;
                }
                if (dataItems.Name == "victimList")
                {
                    XmlNodeList dataContentInventory = dataItems.ChildNodes;
                    foreach (XmlNode dataItemInventory in dataContentInventory)
                    {
                        system.setVictimisHelpbyID(int.Parse(dataItemInventory.Attributes["ID"].Value),true);
                    }
                }
                if (dataItems.Name == "doc")
                {
                    XmlNodeList dataContentInventory = dataItems.ChildNodes;
                    foreach (XmlNode dataItemInventory in dataContentInventory)
                    {
                        phone.docManager.collectDoc(int.Parse(dataItemInventory.Attributes["ID"].Value),true);
                    }
                }
                if (dataItems.Name == "haveConveration")
                {
                    XmlNodeList dataContentInventory = dataItems.ChildNodes;
                    Quest temps = system.getCurrentQuest();
                    foreach (XmlNode dataItemInventory in dataContentInventory)
                    {
                        temps.setConversationFinish(int.Parse(dataItemInventory.Attributes["MapID"].Value),
                            bool.Parse(dataItemInventory.Attributes["haveCon"].Value));
                    }
                    system.setCurrentMission(temps);
                }
                if (dataItems.Name == "smartSystem")
                {
                    XmlNodeList dataContentInventory = dataItems.ChildNodes;
                   
                    foreach (XmlNode dataItemInventory in dataContentInventory)
                    {
                        system.setsmartValue(dataItemInventory.Attributes["MapID"].Value, 
                            int.Parse(dataItemInventory.Attributes["value"].Value));
                    }
                }
            }
        }
        
        Destroy(gameObject);
    }
    public void setChoice(int n)
    {
        choice = n;
    }
    public int getChoice()
    {
        return choice;
    }
    public void loadtopicdata()
    {
        topicdate = new string[4];
        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.LoadXml(PlayerPrefs.GetString("save"));
            for (int i = 0; i < 4; i++)
            {
                if (xmlDoc.GetElementsByTagName("profile" + i) != null)
                {
                    
                    XmlNodeList dataList = xmlDoc.GetElementsByTagName("profile" + i);

                    if (dataList != null)
                    {
                        foreach (XmlNode dataInfo in dataList)
                        {
                            XmlNodeList dataContent = dataInfo.ChildNodes;
                            foreach (XmlNode dataItems in dataContent)
                            {
                                if (dataItems.Name == "time")
                                {
                                    topicdate[i] = dataItems.InnerText;
                                }
                            }
                        }
                    }
                }
            }
        }
        catch
        {
            //do nothing
        }
    }
}

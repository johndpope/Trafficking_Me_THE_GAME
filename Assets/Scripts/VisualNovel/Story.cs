using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Position
{
    left,right,middle
}
public class Story {
    private string ID;
    private string name;
    private string des;
    private Dictionary<int,List<string>> text;
    private Dictionary<int,List<string>> nameCharacters;
    private Dictionary<int,List<string>> choices;
    private Dictionary<int,List<string>> background;
    private Dictionary<int, List<List<string>>> characterPicture;
    private Dictionary<int, List<List<Position>>> characterPosition;
    private List<List<int>> answer;
	// Use this for initialization
    public Story(string ID, string name,string des)
    {
        this.ID = ID;
        this.name = name;
        this.des = des;
        answer = new List<List<int>>();
        text = new Dictionary<int, List<string>>();
        choices = new Dictionary<int, List<string>>();
        nameCharacters = new Dictionary<int, List<string>>();
        characterPicture = new Dictionary<int, List<List<string>>>();
        characterPosition = new Dictionary<int, List<List<Position>>>();
        background = new Dictionary<int, List<string>>();

    }
    public string getID(){
        return ID;
    }
    public string getName()
    {
        return name;
    }
    public string getDes()
    {
        return des;
    }
    public void addConversation(int n,string name, string context, string background,string[] character,Position[] position)
    {
        List<string> checkDictionary;
        if(!text.TryGetValue(n,out checkDictionary)){
            text.Add(n, new List<string>());
            nameCharacters.Add(n, new List<string>());
        }
        nameCharacters[n].Add(name);
        text[n].Add(context);
        
        if (this.background.ContainsKey(n))
        {
            this.background[n].Add(background);
            
        }
        else
        {
            
            this.background.Add(n, new List<string>());
            this.background[n].Add(background);
        }
        List<string> temp1 = new List<string>();
        List<Position> temp2 = new List<Position>();
        for (int i = 0; i < character.Length; i++)
        {
            temp1.Add(character[i]);
            temp2.Add(position[i]);
        }
        if (characterPicture.ContainsKey(n) && characterPosition.ContainsKey(n))
        {
            characterPicture[n].Add(temp1);
            characterPosition[n].Add(temp2);

        }
        else
        {
            characterPicture.Add(n,new List<List<string>>());
            characterPosition.Add(n, new List<List<Position>>());
            characterPicture[n].Add(temp1);
            characterPosition[n].Add(temp2);
        }
    }
    public void addChoices(int n, string choice)
    {
        List<string> checkDictionary;
        if (!choices.TryGetValue(n, out checkDictionary))
        {
            choices.Add(n, new List<string>());
        }
        choices[n].Add(choice);
    }
    public void addAnswer(int n, int answerQuestion, int way, int isquest, int questID)
    {
        List<int> temp = new List<int>();
        temp.Add(n);
        temp.Add(answerQuestion);
        temp.Add(way);
        temp.Add(isquest);
        temp.Add(questID);
        answer.Add(temp);
    }
    public string[] getConversation(int n)
    {
        return text[n].ToArray();
    }
    public string[] getChoice(int n)
    {
        return choices[n].ToArray();
    }
    public int[] getAnswer(int n)
    {
        return answer[n].ToArray();
    }
    public int getPathWay(int n, int ans, out bool isQuest ,out int questID)
    {
        int result =-1;
        bool isquest = false;
        int tempquestID = 0;
        for (int i = 0; i < answer.Count; i++)
        {
            if (answer[i][0] == n && answer[i][1] == ans)
            {
                result = answer[i][2];
                isquest = getisQuest(i);
                tempquestID = answer[i][4];
                break;
            }
        }
        questID = tempquestID;
        isQuest = isquest;
        return result;
    }
    private bool getisQuest(int n)
    {
        int result = answer[n][3];
        if (result == 1)
        {
            return true;
        }
        else
            return false;
    }
    public bool checkHaveQuestion(int n)
    {
        List<string> checkDictionary;
        return choices.TryGetValue(n, out checkDictionary);
    }
    public string[] getNameCharacter(int n)
    {
        return nameCharacters[n].ToArray();
    }
    public string[][] getCharacterPicture(int n)
    {
        string[][] result = new string[1][];
        if(characterPicture.ContainsKey(n)){
            List<List<string>> temp = characterPicture[n];
            result = new string[temp.Count][];
            for (int i = 0; i < temp.Count; i++)
            {
                result[i] = new string[temp[i].Count];
                for (int j = 0; j < temp[i].Count; j++)
                {
                    result[i][j] = temp[i][j];
                }
            }
        }
        return result;
    }
    public Position[][] getCharacterPosition(int n)
    {
        Position[][] result = new Position[1][];
        if (characterPosition.ContainsKey(n))
        {
            List<List<Position>> temp = characterPosition[n];
            result = new Position[temp.Count][];
            for (int i = 0; i < temp.Count; i++)
            {
                result[i] = new Position[temp[i].Count];
                for (int j = 0; j < temp[i].Count; j++)
                {
                    result[i][j] = temp[i][j];
                }
            }
        }
        return result;
    }
    public string[] getBackground(int n)
    {
        string[] result = new string[1];
        if (background.ContainsKey(n))
        {
            result = background[n].ToArray();
        }
        return result;
    }
}

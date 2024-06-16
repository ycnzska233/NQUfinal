using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class card
{
    public string suit;
    public int value;
}

public static class guides
{
    public static int[] p1 = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
    public static int[] p2 = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
    //0=green, 1=red, 2=null
}

public static class decks
{
    //牌堆設計：遊戲卡池、棄牌堆、玩家手牌*2、回合卡牌
    public static List<card> newDeck = new List<card>();
    public static List<card> waste = new List<card>();
    public static List<card> player1 = new List<card>();
    public static List<card> player2 = new List<card>();
    public static List<card> round = new List<card>();

    public static string[] suits = { "anchor", "cannon", "cball", "hook", "key", "map", "mermaid", "monster", "sword", "tbox" };
    public static List<string> suit = new List<string>(suits);

    public static int[] score = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static List<int> p1score = new List<int>(score);
    public static List<int> p2score = new List<int>(score);

    //shuffle
    public static List<card> ShuffleDeck(List<card> theDeck)
    {
        //空列表：儲存打亂的牌
        List<card> tmp = new List<card>();

        //亂數取牌製作新牌堆tmp
        Random random = new Random();
        for (int i = theDeck.Count; i > 0; i--)
        {
            int j = random.Next(i);
            tmp.Add(new card { suit = theDeck[j].suit, value = theDeck[j].value });
            theDeck.RemoveAt(j);
        }
        return tmp;
    }

    //將卡牌依花色加入玩家的牌堆
    public static List<int> p1s0 = new List<int>();
    public static List<int> p2s0 = new List<int>();
    public static List<int> p1s1 = new List<int>();
    public static List<int> p2s1 = new List<int>();
    public static List<int> p1s2 = new List<int>();
    public static List<int> p2s2 = new List<int>();
    public static List<int> p1s3 = new List<int>();
    public static List<int> p2s3 = new List<int>();
    public static List<int> p1s4 = new List<int>();
    public static List<int> p2s4 = new List<int>();
    public static List<int> p1s5 = new List<int>();
    public static List<int> p2s5 = new List<int>();
    public static List<int> p1s6 = new List<int>();
    public static List<int> p2s6 = new List<int>();
    public static List<int> p1s7 = new List<int>();
    public static List<int> p2s7 = new List<int>();
    public static List<int> p1s8 = new List<int>();
    public static List<int> p2s8 = new List<int>();
    public static List<int> p1s9 = new List<int>();
    public static List<int> p2s9 = new List<int>();

    public static void playerUpdate(string player)
    {
        switch (player)
        {
            case "p1":
                p1s0.Clear();
                p1s1.Clear();
                p1s2.Clear();
                p1s3.Clear();
                p1s4.Clear();
                p1s5.Clear();
                p1s6.Clear();
                p1s7.Clear();
                p1s8.Clear();
                p1s9.Clear();
                p1score = new List<int>(score);
                for (int i=0; i < player1.Count; i++)
                {
                    switch (player1[i].suit)
                    {
                        case "anchor":
                            p1s0.Add(player1[i].value);
                            p1s0.Sort();
                            p1score[0] = p1s0[p1s0.Count - 1];
                            break;
                        case "cannon":
                            p1s1.Add(player1[i].value);
                            p1s1.Sort();
                            p1score[1] = p1s1[p1s1.Count - 1];
                            break;
                        case "cball":
                            p1s2.Add(player1[i].value);
                            p1s2.Sort();
                            p1score[2] = p1s2[p1s2.Count - 1];
                            break;
                        case "hook":
                            p1s3.Add(player1[i].value);
                            p1s3.Sort();
                            p1score[3] = p1s3[p1s3.Count - 1];
                            break;
                        case "key":
                            p1s4.Add(player1[i].value);
                            p1s4.Sort();
                            p1score[4] = p1s4[p1s4.Count - 1];
                            break;
                        case "map":
                            p1s5.Add(player1[i].value);
                            p1s5.Sort();
                            p1score[5] = p1s5[p1s5.Count - 1];
                            break;
                        case "mermaid":
                            p1s6.Add(player1[i].value);
                            p1s6.Sort();
                            p1score[6] = p1s6[p1s6.Count - 1];
                            break;
                        case "monster":
                            p1s7.Add(player1[i].value);
                            p1s7.Sort();
                            p1score[7] = p1s7[p1s7.Count - 1];
                            break;
                        case "sword":
                            p1s8.Add(player1[i].value);
                            p1s8.Sort();
                            p1score[8] = p1s8[p1s8.Count - 1];
                            break;
                        case "tbox":
                            p1s9.Add(player1[i].value);
                            p1s9.Sort();
                            p1score[9] = p1s9[p1s9.Count - 1];
                            break;
                    }                    
                }
                break;             

            case "p2":
                p2s0.Clear();
                p2s1.Clear();
                p2s2.Clear();
                p2s3.Clear();
                p2s4.Clear();
                p2s5.Clear();
                p2s6.Clear();
                p2s7.Clear();
                p2s8.Clear();
                p2s9.Clear();
                p2score = new List<int>(score);
                for (int i = 0; i < player2.Count; i++)
                {
                    switch (player2[i].suit)
                    {
                        case "anchor":
                            p2s0.Add(player2[i].value);
                            p2s0.Sort();
                            p2score[0] = p2s0[p2s0.Count - 1];
                            break;
                        case "cannon":
                            p2s1.Add(player2[i].value);
                            p2s1.Sort();
                            p2score[1] = p2s1[p2s1.Count - 1];
                            break;
                        case "cball":
                            p2s2.Add(player2[i].value);
                            p2s2.Sort();
                            p2score[2] = p2s2[p2s2.Count - 1];
                            break;
                        case "hook":
                            p2s3.Add(player2[i].value);
                            p2s3.Sort();
                            p2score[3] = p2s3[p2s3.Count - 1];
                            break;
                        case "key":
                            p2s4.Add(player2[i].value);
                            p2s4.Sort();
                            p2score[4] = p2s4[p2s4.Count - 1];
                            break;
                        case "map":
                            p2s5.Add(player2[i].value);
                            p2s5.Sort();
                            p2score[5] = p2s5[p2s5.Count - 1];
                            break;
                        case "mermaid":
                            p2s6.Add(player2[i].value);
                            p2s6.Sort();
                            p2score[6] = p2s6[p2s6.Count - 1];
                            break;
                        case "monster":
                            p2s7.Add(player2[i].value);
                            p2s7.Sort();
                            p2score[7] = p2s7[p2s7.Count - 1];
                            break;
                        case "sword":
                            p2s8.Add(player2[i].value);
                            p2s8.Sort();
                            p2score[8] = p2s8[p2s8.Count - 1];
                            break;
                        case "tbox":
                            p2s9.Add(player2[i].value);
                            p2s9.Sort();
                            p2score[9] = p2s9[p2s9.Count - 1];
                            break;
                    }
                }                
                break;
        }

        digit.player1Score = 0;
        digit.player2Score = 0;
        for (int i = 0; i < 10; i++)
        {
            digit.player1Score += p1score[i];
            digit.player2Score += p2score[i];
        }
    }

    //卡牌功能發動

    public static int anchor = 0;
    public static bool cball = false;
    public static bool key = false;
    public static bool tbox = false;
    public static int monster = 0;
    public static bool target = false;
    public static bool hook = false;
    public static int map = -1;
    public static bool sword = false;

    public static void suitAbility(string suit)
    {
        switch (suit)
        {
            case "anchor":
                //you can take your draw before this card when you bust
                anchor = draw.drawCount;
                break;
            case "cannon":
                //target one card from enemy's deck, the card goes to wasted deck
                if (draw.round % 2 != 0 && player2.Count != 0)
                {
                    target = true;
                    for (int i = 0; i < 10; i++) { if (p2score[i] != 0) { guides.p2[i] = 0; } }
                }
                else if (draw.round % 2 == 0 && player1.Count != 0)
                {
                    target = true;
                    for (int i = 0; i < 10; i++) { if (p1score[i] != 0) { guides.p1[i] = 0; } }
                }     
                break;
            case "cball":
                //preview next card from card deck
                cball = true;
                break;
            case "hook":
                //take one card from your own deck
                if (draw.round % 2 != 0 && player1.Count != 0)
                {
                    hook = true;
                    for(int i = 0; i < 10; i++)
                    {
                        if (p1score[i] != 0)
                        {
                            guides.p1[i] = 0;
                            for(int j = 0; j < round.Count; j++)
                            {
                                if (suits[i] == round[j].suit) { guides.p1[i] = 1; }
                            }
                        }
                    }                 
                }
                else if (draw.round % 2 == 0 && player2.Count != 0)
                {
                    hook = true;
                    for (int i = 0; i < 10; i++)
                    {
                        if (p2score[i] != 0)
                        {
                            guides.p2[i] = 0;
                            for (int j = 0; j < round.Count; j++)
                            {
                                if (suits[i] == round[j].suit) { guides.p2[i] = 1; }
                            }
                        }
                    }
                }
                break;
            case "key":
                //collect with tbox to take double from wasted deck
                key = true;
                break;
            case "map":
                //pick one card out of 3 random card from wasted deck to the board
                waste = ShuffleDeck(waste);
                if (waste.Count >= 3) { map = 3; }
                else if (waste.Count != 0) { map = waste.Count; }
                break;
            case "mermaid":
                //gain more point
                break;
            case "monster":
                //you can't take your draw this round before you draw another 2 cards after this card
                monster = 2;
                break;
            case "sword":
                //take one card from opponent's deck (you can only pick the suit you don't have in your own deck
                if (draw.round % 2 != 0 && player2.Count != 0)
                {
                    for(int i = 0; i < 10; i++)
                    {
                        if (p1score[i] == 0 && p2score[i] != 0)
                        {
                            guides.p2[i] = 0;
                            for (int j = 0; j < round.Count; j++)
                            {
                                if (suits[i] == round[j].suit) { guides.p2[i] = 1; }
                                sword = true;
                            }
                        }
                        
                    }
                }
                else if (draw.round % 2 == 0 && player1.Count != 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (p2score[i] == 0 && p1score[i] != 0)
                        {
                            guides.p1[i] = 0;
                            for (int j = 0; j < round.Count; j++)
                            {
                                if (suits[i] == round[j].suit) { guides.p1[i] = 1; }
                                sword = true;
                            }
                        }
                    }
                }
                break;
            case "tbox":
                //collect with key to take double from wasted deck
                tbox = true;
                break;
        }
    }
}

public class cards : MonoBehaviour
{    
}
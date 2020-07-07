using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 덱,묘지,손패를 관리하는 클래스
/// 적이 손패가 있을 수 있으므로 싱글턴 아님
/// </summary>
public class CardInBattleManager
{
    private const int handMax = 9;

    private List<CardModelInBattle> _hands = new List<CardModelInBattle>();
    /// <summary>
    /// 0번이 가장 위에 있는 카드
    /// </summary>
    private List<CardModelInBattle> _inDecks = new List<CardModelInBattle>();
    private List<CardModelInBattle> _discardeds = new List<CardModelInBattle>();

    /// <summary>
    /// 덱 초기화
    /// </summary>
    public void InitByDeck(List<CardModelInBattle> cardList)
    {
        _hands.Clear();
        _inDecks.Clear();
        _discardeds.Clear();

        _inDecks.AddRange(cardList);
    }

    public void DrawCard(int count)
    {
        for(int i=0; i<count; i++)
        {
            if(_inDecks.Count == 0)
            {
                // 카드 떨어졌음 없음 알림
                break;
            }

            var card = _inDecks[0];
            _inDecks.RemoveAt(0);

            if(_hands.Count < handMax)
            {
                _hands.Add(card);
            }
            else
            {
                // 손패가 꽉참 알림
                _discardeds.Add(card);
            }
        }
    }
}

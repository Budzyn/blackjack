using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Cards:Game
    {
        /* card_suit масть карти
         * 1-чирва
         * 2-бубна
         * 3-трефа
         * 4-піка
         * num-номер карти
         * 2-двійка
         * ....
         * 10-десятка
         * 11-валет
         * 12-дама
         * 13-король
         * 14-туз
         */
        public int card_suit;
        public int num;
        public Cards(int i, int j)
        {
            this.card_suit = i;
            this.num = j;
        }

        public Cards[] koloda = new Cards[52];
        public Cards()
        {
            for (int i = 1; i <= 4; i++)
                for (int j = 2; j <= 21; j++)
                    koloda[(i - 1) * 9 + (j - 5)] = new Cards(i, j);
        }
        public string OutCards(int Id)
        {
            string answer;
            switch (koloda[Id].num)
            {
                case 11:
                    answer = "Валет";
                    break;
                case 12:
                    answer = "Дама";
                    break;
                case 13:
                    answer = "Король";
                    break;
                case 14:
                    answer = "Туз";
                    break;
                default:
                    answer = koloda[Id].num.ToString();
                    break;
            }
            switch (koloda[Id].card_suit)
            {
                case 1:
                    answer += " чирвів";
                    break;
                case 2:
                    answer += " бубнів";
                    break;
                case 3:
                    answer += " трефів";
                    break;
                case 4:
                    answer += " пік";
                    break;
            }
            return answer;
        }
        public void Sort()
        {

        }
    }
}

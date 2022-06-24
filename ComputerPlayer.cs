using System;
using System.Collections.Generic;


using System.Text;

namespace XOGame
{
    public class ComputerPlayer
    {
        private int[] _points = new int[9];
        private int Mychoice;
        private int EnemyChoice;

        private List<int> _emptyPoint = new List<int>();
      

        public ComputerPlayer(int[] Points,int Choice)
        {
            _points = Points;
            Mychoice = Choice;
            if (Mychoice == 0)
                EnemyChoice = 1;
            else
                EnemyChoice = 0;
        }

        public int SelectButton()
        {
            int result;

            if (IsFirstAct())
                result = Random();
            else
            {
                SetEmptyPoint();           
                result = BestChoice();              
            }
            return result;
        }

        private int BestChoice()
        {
            int result = 0;
            int sum1, sum2, sum3, sum4, sum5, sum6, sum7, sum8;

            sum1 = _points[0] + _points[1] + _points[2];
            sum2 = _points[3] + _points[4] + _points[5];
            sum3 = _points[6] + _points[7] + _points[8];
            sum4 = _points[0] + _points[3] + _points[6];
            sum5 = _points[1] + _points[4] + _points[7];
            sum6 = _points[2] + _points[5] + _points[8];
            sum7 = _points[0] + _points[4] + _points[8];
            sum8 = _points[2] + _points[4] + _points[6];

            if (Mychoice == 0)
            {
                if (sum1 == 9)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(3))
                        result = 3;
                }
                else if (sum2 == 9)
                {
                    if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                }
                else if (sum3 == 9)
                {
                    if (CheckPointIsEmpty(7))
                        result = 7;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum4 == 9)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else if (sum5 == 9)
                {
                    if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                }
                else if (sum6 == 9)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum7 == 9)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum8 == 9)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else if (sum1 == 11)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(3))
                        result = 3;
                }
                else if (sum2 == 11)
                {
                    if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                }
                else if (sum3 == 11)
                {
                    if (CheckPointIsEmpty(7))
                        result = 7;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum4 == 11)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else if (sum5 == 11)
                {
                    if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                }
                else if (sum6 == 11)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum7 == 11)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum8 == 11)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else
                    result = Random(_emptyPoint.Count);
            }

            if (Mychoice == 1)
            {
                if (sum1 == 11)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(3))
                        result = 3;
                }
                else if (sum2 == 11)
                {
                    if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                }
                else if (sum3 == 11)
                {
                    if (CheckPointIsEmpty(7))
                        result = 7;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum4 == 11)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else if (sum5 == 11)
                {
                    if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                }
                else if (sum6 == 11)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum7 == 11)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum8 == 11)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else if (sum1 == 9)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(3))
                        result = 3;
                }
                else if (sum2 == 9)
                {
                    if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                }
                else if (sum3 == 9)
                {
                    if (CheckPointIsEmpty(7))
                        result = 7;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum4 == 9)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(4))
                        result = 4;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else if (sum5 == 9)
                {
                    if (CheckPointIsEmpty(2))
                        result = 2;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(8))
                        result = 8;
                }
                else if (sum6 == 9)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(6))
                        result = 6;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum7 == 9)
                {
                    if (CheckPointIsEmpty(1))
                        result = 1;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(9))
                        result = 9;
                }
                else if (sum8 == 9)
                {
                    if (CheckPointIsEmpty(3))
                        result = 3;
                    else if (CheckPointIsEmpty(5))
                        result = 5;
                    else if (CheckPointIsEmpty(7))
                        result = 7;
                }
                else
                    result = Random(_emptyPoint.Count);
            }
       
            return result;
        }

        private bool IsFirstAct()
        {
            if (_points[0] == 9 && _points[1] == 9 && _points[2] == 9 && _points[3] == 9 && _points[4] == 9 && _points[5] == 9 && _points[6] == 9 && _points[7] == 9 && _points[8] == 9)
                return true;
            else
                return false;
        }

        private int Random()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 9);
            return result;
        }

        private void SetEmptyPoint()
        {
            for (int i = 0; i < 9; i++)
            {
                if (_points[i] == 9)
                    _emptyPoint.Add(i+1);
            }
        }

        private int Random(int Index)
        {
            Random rnd = new Random();
            int idx = rnd.Next(0, Index);
            int result = _emptyPoint[idx];

            return result;
        }         

        private bool CheckPointIsEmpty(int BtNum)
        {
            int index = _emptyPoint.BinarySearch(BtNum);
            if (index < 0)
                return false;
            else
                return true;
        }    
    }
}

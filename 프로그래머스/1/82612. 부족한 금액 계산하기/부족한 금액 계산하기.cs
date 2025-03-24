using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long didtla = 0;
        for(int i=1;i<=count;i++)
        {
            didtla += price*i;
        }
        
        if(money < didtla)
        {
            return didtla-money;
        }
        else
        {
            return 0;
        }
    }
}
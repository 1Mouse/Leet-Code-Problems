public class Solution
{
    public bool IsPowerOfThree(int n)
    {

        // all steps recursion

        /*if(n<=0){
            return false;
        }
        else if(n==1)
        {
            return true;
        }
        else if(n%3!=0){
            return false;
        }
        else if(n%3==0){
            n=n/3;
            return IsPowerOfThree(n);
        }
        else{
            return false;
        }*/

        //one line recursion
        return n > 0 && (n == 1 || (n % 3 == 0 && IsPowerOfThree(n / 3)));

    }
}
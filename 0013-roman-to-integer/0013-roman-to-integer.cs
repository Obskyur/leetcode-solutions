public class Solution {
    public int RomanToInt(string s) {
        int retVal = 0, prevVal = int.MaxValue;
        foreach ( char c in s ) {
            int curVal = getVal(c);
            if (prevVal < curVal)
                retVal -= 2 * prevVal;
            retVal += curVal;
            prevVal = curVal;
        };
        return retVal;
    }

    private int getVal(char c) => c switch {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000
    };
}
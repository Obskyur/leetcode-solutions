public class Solution {
    string[] digitStrings = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
    string[] teens = {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    string[] tens = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

    public string NumberToWords(int num) {
        if (num == 0) return "Zero";
        if (num > 0 && num < 10) return digitStrings[num];
        if (num >= 10 && num < 20) return teens[num % 10];
        if (num >= 20 && num < 100)
            return $"{tens[num / 10]} {(num % 10 == 0 ? string.Empty : NumberToWords(num % 10))}".Trim();
        if (num >= 100 && num < 1000)
            return $"{NumberToWords(num / 100)} Hundred {(num % 100 == 0 ? string.Empty : NumberToWords(num % 100))}".Trim();
        if (num >= 1000 && num < 1e6)
            return $"{NumberToWords(num / 1000)} Thousand {(num % 1000 == 0 ? string.Empty : NumberToWords(num % 1000))}".Trim();
        if (num >= 1e6 && num < 1e9)
            return $"{NumberToWords(num / (int)1e6)} Million {(num % (int)1e6 == 0 ? string.Empty : NumberToWords(num % (int)1e6))}".Trim();
        if (num >= 1e9)
            return $"{NumberToWords(num / (int)1e9)} Billion {(num % (int)1e9 == 0 ? string.Empty : NumberToWords(num % (int)1e9))}".Trim();
        return "";
    }
}
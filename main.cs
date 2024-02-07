public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int word_length1 = word1.Length;
        int word_length2 = word2.Length;
        string word3 = "";
        int i = 0;

        while(i < word_length1 || i < word_length2)
        {
            if(i < word_length1)
            {
                word3 += word1[i];
            }
            if(i < word_length2)
            {
                word3 += word2[i];
            }
            i++;
        }
        return word3;
    }
}

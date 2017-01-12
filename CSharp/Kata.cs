using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/complementary-dna/train/csharp
/// </summary>
public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        var list = new List<char>();
        foreach (var item in dna)
        {
            switch (item)
            {
                case 'A':
                    list.Add('T');
                    break;
                case 'T':
                    list.Add('A');
                    break;
                case 'C':
                    list.Add('G');
                    break;
                case 'G':
                    list.Add('C');
                    break;
            }
        }
        return string.Join(string.Empty, list);
    }
}
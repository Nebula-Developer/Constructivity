using System;
using System.Collections.Generic;

namespace Constructivity {
    public class Construct {
        public static string[] vowel = new string[] {
            "a", "e", "i", "o", "u"
        };

        public static string[] vowelCapital = new string[] {
            "A", "E", "I", "O", "U"
        };

        public static string[] consonants = new string[] {
            "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "qu", "r", "s", "t", "v", "w", "x", "y", "z", "pp", "ll", "tt"
        };

        public static string[] suffixes = new string[] {
            "port", "mend", "land", "mort", "table"
        };

        public static string[] enders = new string[] {
            "el", "em", "is", "am", "or", "in"
        };

        public static string[] punctuation = new string[] {
            ".", ",", ".", ",", ",", "!", "?", "..", " &" 
        };

        public static string[] consonantStart = new string[] {
            "k", "m", "n", "j", "w", "p"
        };

        public static string[] consonantStartCapital = new string[] {
            "K", "M", "N", "J", "W", "P"
        };

        public static string[] midConsonant = new string[] {
            "l", "n", "m", "s", "y", "ll"
        };

        public static string[] endConsonant = new string[] {
            "d", "b", "k", "p"
        };

        public static string[] words = new string[] {
            "the", "of", "and", "or", "in", "because", "nation", "party",
            "house", "blame", "totally", "construct", "word", "character",
            "append", "delete", "create", "person", "human", "magic"
        };

        public static void switchOddChars(bool toggle) {
            if (toggle) {
                consonants = new string[] {
                    "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "qu", "r", "s", "t", "v", "w", "x", "y", "z", "pp", "ll", "tt"
                };
            } else {
                consonants = new string[] {
                    "b", "c", "d", "f", "g", "h", "k", "l", "m", "n", "p", "r", "s", "t", "w", "pp", "ll", "tt"
                };
            }
        }

        public static string NewWordSentence(int sentenceLength, bool usePunctuation = true) {

            return "";
        }

        public static string NewRandomSentence(int sentenceLength, bool oddChars = false, bool usePunctuation = true) {
            Random r = new Random();
            string builtString = "";
            string currentWord = "";
            bool isInBrackets = false;
            List<string> noRepeats = new List<string>();
            string tempConstructedPunctuation = "";

            switchOddChars(oddChars);
            bool addCapital = true;

            
            for (int i = 0; i < sentenceLength; i++) {
                currentWord = "";

                if (r.Next(0, 100) == 5) {
                    currentWord += r.Next(0,50);
                    if (r.Next(0, 30) == 3) {
                        currentWord += '-';
                        currentWord += r.Next(0,50);
                    } else if (r.Next(0, 30) == 5) {
                        currentWord += 'x';
                    }
                    currentWord += ' ';
                }
                
                if (r.Next(0, 300) == 1 && usePunctuation && !isInBrackets) {
                    currentWord += "(";
                    isInBrackets = true;
                }

                if (r.Next(0, 3) == 1) {
                    if (addCapital) {
                        addCapital = false;
                        currentWord += consonantStartCapital[r.Next(0, consonantStartCapital.Length)];
                    } else {
                        currentWord += consonantStart[r.Next(0, consonantStart.Length)];
                    }
                    
                    currentWord += vowel[r.Next(0, vowel.Length)];
                    currentWord += midConsonant[r.Next(0, midConsonant.Length)];
                    currentWord += endConsonant[r.Next(0, endConsonant.Length)];
                    if (isInBrackets && r.Next(0, 4) == 1) {
                        isInBrackets = false;
                        currentWord += ")";
                    }
                    currentWord += ' '; // ------------------------------------
                    builtString += currentWord;
                    noRepeats.Add(currentWord);
                    if (noRepeats.Contains(currentWord)) {
                        currentWord = "";
                        i--;
                    }
                    if (noRepeats.Count > 20) {
                        noRepeats.RemoveAt(0);
                    }
                    continue;
                } else if (r.Next(0, 3) == 2) {
                    if (addCapital) {
                        addCapital = false;
                        currentWord += consonantStartCapital[r.Next(0, consonantStartCapital.Length)];
                    } else {
                        currentWord += consonantStart[r.Next(0, consonantStart.Length)];
                    }
                    currentWord += vowel[r.Next(0, vowel.Length)];
                    currentWord += midConsonant[r.Next(0, midConsonant.Length)];
                    currentWord += vowel[r.Next(0, vowel.Length)];
                    currentWord += endConsonant[r.Next(0, endConsonant.Length)];
                    if (r.Next(0, 2) == 1) {
                        currentWord += vowel[r.Next(0, vowel.Length)];
                        currentWord += midConsonant[r.Next(0, midConsonant.Length)];
                        currentWord += endConsonant[r.Next(0, endConsonant.Length)];
                    }
                    if (isInBrackets && r.Next(0, 4) == 1) {
                        isInBrackets = false;
                        currentWord += ")";
                    }
                    currentWord += ' '; // ------------------------------------
                    builtString += currentWord;
                    noRepeats.Add(currentWord);
                    if (noRepeats.Contains(currentWord)) {
                        currentWord = "";
                        i--;
                    }
                    if (noRepeats.Count > 20) {
                        noRepeats.RemoveAt(0);
                    }
                    continue;
                }

                if (addCapital) {
                    addCapital = false;
                    currentWord += vowelCapital[r.Next(0, vowel.Length)];
                } else {
                    currentWord += vowel[r.Next(0, vowel.Length)];
                }
                currentWord += consonants[r.Next(0, consonants.Length)];
                if (r.Next(0, 4) == 1) {
                    currentWord += ' '; // ------------------------------------
                    builtString += currentWord;
                    noRepeats.Add(currentWord);
                    if (noRepeats.Contains(currentWord)) {
                        currentWord = "";
                        i--;
                    }
                    if (noRepeats.Count > 20) {
                        noRepeats.RemoveAt(0);
                    }
                    continue;
                }
                currentWord += vowel[r.Next(0, vowel.Length)];
                
                if (r.Next(0, 2) == 1) {
                    currentWord += vowel[r.Next(0, vowel.Length)];
                    currentWord += consonants[r.Next(0, consonants.Length)];
                    currentWord += enders[r.Next(0, enders.Length)];
                }
                if (r.Next(0, 2) == 1) {
                    currentWord += suffixes[r.Next(0, suffixes.Length)];
                }
                if(r.Next(0, 2) == 1 && usePunctuation) {
                    string puncuationToCheck =  punctuation[r.Next(0, punctuation.Length)];
                    if (puncuationToCheck == "." || puncuationToCheck == ".." || puncuationToCheck == "!" || puncuationToCheck == "?") {
                        addCapital = true;
                    }
                    currentWord += puncuationToCheck;
                    tempConstructedPunctuation = puncuationToCheck;
                } else {
                    tempConstructedPunctuation = "";
                }

                if (isInBrackets && r.Next(0, 4) == 1) {
                    isInBrackets = false;
                    currentWord += ")";
                }

                currentWord += ' ';

                builtString += currentWord;
            }

            if (isInBrackets) {
                builtString = builtString.Substring(0, builtString.Length - 1);
                builtString += ")";
            }
            return builtString;
        }
    }
}
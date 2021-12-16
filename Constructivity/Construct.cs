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

        public static string[] puncuation = new string[] {
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

        public static string[] doubleChar = new string[] {
            "ll", "pp", "tt"
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

        public static string[] alph = new string[] {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        public static string SingleCharLength(int sentenceLength) {
            string builtString = "";
            for (int i = 0; i < sentenceLength; i++) {
                for (int b = 0; b < new Random().Next(3, 14); b++) {
                    builtString += '*';
                }
                builtString += ' ';
            }
            return builtString;
        }

        public static string RandomChars(int sentenceLength) {
            string builtString = "";
            for (int i = 0; i < sentenceLength; i++) {
                for (int b = 0; b < new Random().Next(3, 11); b++) {
                    builtString += ran(alph);
                }
                builtString += ' ';
            }
            return builtString;
        }

        public static string NewModernSentence(int sentenceLength, bool usePunctuation = true) {
            string currentWord = "";
            string builtString = "";
            bool addCapital = true;

            for (int i = 0; i < sentenceLength; i++) {
                int wordLength = new Random().Next(3, 11);
                currentWord = "";

                if (ranBool(4)) { 
                    if (addCapital) { 
                        addCapital = false;
                        currentWord += ran(consonantStartCapital);
                    } else {
                        currentWord += ran(consonantStart);
                    }
                } else {
                    if (addCapital) { 
                        addCapital = false;
                        currentWord += ran(vowelCapital);
                    } else {
                        currentWord += ran(vowel);
                    }
                }

                if (ranBool(4)) {
                    currentWord += ran(doubleChar);
                    currentWord += ran(vowel);
                    currentWord += ran(midConsonant);
                    currentWord += ran(endConsonant);
                } else { 
                    currentWord += ran(endConsonant);
                    currentWord += ran(vowel);
                    if (ranBool(4)) {
                        currentWord += ran(midConsonant);
                        currentWord += ran(vowel);
                        currentWord += ran(endConsonant);
                    } else {
                        currentWord += ran(endConsonant);
                    }
                }

                if (ranBool(5)) {
                    string puncuationToCheck =  ran(puncuation);
                    if (puncuationToCheck == "." || puncuationToCheck == ".." || puncuationToCheck == "!" || puncuationToCheck == "?") {
                        addCapital = true;
                    }
                    currentWord += puncuationToCheck;
                }
                
                currentWord += ' ';
                builtString += currentWord;
            }
            
            return builtString;
        }

        public static string NewRandomSentence(int sentenceLength, bool oddChars = false, bool usePunctuation = true) {
            string builtString = "";
            bool addCapital = true;
            switchOddChars(oddChars);
            for (int i = 0; i < sentenceLength; i++) {
                for (int b = 0; b < new Random().Next(1, 4); b++) {
                    if (ranBool(3)) {
                        if (!addCapital) {
                            builtString += ran(vowel);
                        } else {
                            addCapital = false;
                            builtString += ran(vowelCapital);
                        }
                    } else {
                        if (!addCapital) {
                            builtString += ran(consonantStart);
                        } else {
                            addCapital = false;
                            builtString += ran(consonantStartCapital);
                        }
                    }
                    
                    builtString += ran(midConsonant);
                    builtString += ran(endConsonant);
                }
                if (ranBool(6)) {
                    builtString += ran(suffixes);
                }
                if (ranBool(6)) {
                    string puncuationToCheck =  ran(puncuation);
                    if (puncuationToCheck == "." || puncuationToCheck == ".." || puncuationToCheck == "!" || puncuationToCheck == "?") {
                        addCapital = true;
                    }
                    builtString += puncuationToCheck;
                }
                builtString += ' ';
            }
            return builtString;
        }

        public static bool ranBool(int Range) {
            bool g = false;
            if (new Random().Next(0, Range) == 1) {
                g = true;
            }
            return g;
        }

        public static string ran(string[] stringsToChooseFrom) {
            return stringsToChooseFrom[new Random().Next(0, stringsToChooseFrom.Length)];
        }
    }
}
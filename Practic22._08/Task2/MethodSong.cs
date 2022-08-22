using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._08.Task2
{
    internal class MethodSong : IMethodSong
    {
        private readonly ISong song;
        public MethodSong(ISong song)
        {
            this.song = song;
        }

        public string GetAllSong()
        {
            return $"Название песни: {song.Name}\n" + 
                $"Автор: {song.Author}\n" +
                $"Год выпуска: {song.Date}\n" +
                $"Краткий текст: {song.TextSong}\n";
        }

        public string GetSongByMorze(string text)
        {
            char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

            string[] codeMorse = new string[] { "–", "–**", "––", "––",
                                                        "–", "", "–", "––",
                                                        "", "–––", "––", "–**",
                                                        "––", "–", "–––", "––",
                                                        "–", "", "–", "–",
                                                        "**–", "*", "––",
                                                        "–––", "––––", "−−−",
                                                        "−−−", "−−", "−",
                                                        "−−", "−−", "*−−−−",
                                                        "−−−", "−−", "**−",
                                                        "**", "−*", "−−",
                                                        "−−−*", "−−−−", "−−−−−" };

            text = text.ToUpper();
            int index;
            string textMorze = "";
            foreach(char i in text)
            {
                if(char.IsDigit(i) || char.IsLetter(i) && i != '\n')
                {
                    index = Array.IndexOf(characters, i);
                    textMorze += codeMorse[index] + " ";
                }
                else
                {
                    textMorze += ".";
                }
            }
            return textMorze;
        }
    }
}

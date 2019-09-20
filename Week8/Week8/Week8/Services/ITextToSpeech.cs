using System;
using System.Collections.Generic;
using System.Text;

namespace Week8.Services
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
